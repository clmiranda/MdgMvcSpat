using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionSeguimientos.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class SeguimientoController : Controller
    {
        private static RestClient client;
        private static IEnumerable<User> _listaVolun;
        private static Seguimiento _seguimiento;
        //private static IEnumerable<ReporteSeguimiento> _listaReportes;
        private static int idSeguimiento;
        private static int? pagesize = 10; private static int? pagenumber = 1; private static string filtrado = "Activo";
        public SeguimientoController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Lista()
        {
            ViewData["filter"] = filtrado;
            var vista = await Listado();
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string filter = "Activo")
        {
            pagesize = sizePage;
            pagenumber = currentPage;
            //busqueda = search;
            filtrado = filter;
            //ViewData["currentPage"] = currentPage;
            //ViewData["itemsPerPage"] = sizePage;
            ViewData["filter"] = filter;
            //ViewData["search"] = search;
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        public async Task<IActionResult> Asignar(int id)
        {
            idSeguimiento = id;
            //var listaVoluntarios = await restVoluntario.GetAsync("api/Seguimiento/GetAllVoluntarios/", HttpContext.Session.GetString("JWToken"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestVolun = new RestRequest("api/Seguimiento/GetAllVoluntarios/", Method.GET);
            var responseVolun = await client.ExecuteAsync<IEnumerable<User>>(requestVolun);
            if (!responseVolun.IsSuccessful)
            {
                switch (responseVolun.StatusCode.ToString())
                {
                    case "BadRequest":
                        return BadRequest();
                    case "NotFound":
                        return NotFound();
                }
            }
            _listaVolun = responseVolun.Data;
            //var seguimiento = await rest.GetAsync(id, "api/Seguimiento/GetSeguimiento/" + id, HttpContext.Session.GetString("JWToken"));
            var requestSeg = new RestRequest("api/Seguimiento/GetSeguimiento/" + id, Method.GET);
            var responseSeg = await client.ExecuteAsync<Seguimiento>(requestSeg);
            if (!responseSeg.IsSuccessful)
            {
                switch (responseSeg.StatusCode.ToString())
                {
                    case "BadRequest":
                        return BadRequest();
                    case "NotFound":
                        return NotFound();
                }
            }
            _seguimiento = responseSeg.Data;
            var tupleModel = new Tuple<IEnumerable<User>, Seguimiento>(responseVolun.Data, responseSeg.Data);
            return View(tupleModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckAsignar(int idUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestUserVolun = new RestRequest("api/Seguimiento/" + idSeguimiento + "/CheckAsignar/" + idUser, Method.PUT);
            try
            {
                //var resul = await restVoluntario.PutAsync("api/Seguimiento/" + idSeguimiento + "/User/" + idUser);
                var responseUser = await client.ExecuteAsync<IEnumerable<User>>(requestUserVolun);
                if (!responseUser.IsSuccessful)
                    throw new Exception(responseUser.Content);
                TempData["alertsuccess"] = "Usuario asignado correctamente.";
                //var requestSeg = new RestRequest("api/Seguimiento/GetSeguimiento/" + idSeguimiento, Method.GET);
                //var responseSeg = await client.ExecuteAsync<Seguimiento>(requestSeg);
                return Json(new { isValid = true, url = Url.Action("Lista", "Seguimiento", new {area= "AdministracionSeguimientos" }) /*html = Helper.RenderRazorViewToString(this, "PartialView/_Asignar", new Tuple<IEnumerable<User>, Seguimiento>(responseUser.Data, responseSeg.Data)) */});
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "PartialView/_Asignar", new Tuple<IEnumerable<User>, Seguimiento>(_listaVolun, _seguimiento)) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveVoluntarioChecked(int idUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestUserVolun = new RestRequest("api/Seguimiento/"+ idSeguimiento + "/RemoveVoluntarioChecked/" + idUser, Method.PUT);
            try
            {
                //var resul = await restVoluntario.PutAsync("api/Seguimiento/" + idSeguimiento + "/User/" + idUser);
                var responseUser = await client.ExecuteAsync<IEnumerable<User>>(requestUserVolun);
                if (!responseUser.IsSuccessful)
                    throw new Exception(responseUser.Content);
                TempData["alertsuccess"] = "Usuario asignado correctamente.";
                var requestSeg = new RestRequest("api/Seguimiento/GetSeguimiento/" + idSeguimiento, Method.GET);
                var responseSeg = await client.ExecuteAsync<Seguimiento>(requestSeg);
                return Json(new {/* isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Asignar", new Tuple<IEnumerable<User>, Seguimiento>(responseUser.Data, responseSeg.Data)) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { /*isValid = false,*/ html = Helper.RenderRazorViewToString(this, "PartialView/_Asignar", new Tuple<IEnumerable<User>, Seguimiento>(_listaVolun, _seguimiento)) });
            }
        }
        public async Task<IEnumerable<Seguimiento>> Listado()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestGet = new RestRequest("api/Seguimiento/GetAllSeguimiento", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
            var responseGet = await client.ExecuteAsync<IEnumerable<Seguimiento>>(requestGet);
            var header = responseGet.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
            var head = JObject.Parse(header.Value.ToString());
            ViewData["currentPage"] = head["currentPage"].ToString();
            ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
            ViewData["totalItems"] = head["totalItems"].ToString();
            ViewData["totalPages"] = head["totalPages"].ToString();
            var vista = responseGet.Data;
            return vista;
        }
    }
}
