using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModalidadGradoSpat.Reports;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Areas.AdministracionSeguimientos.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class SeguimientoController : Controller
    {
        private static RestClient client;
        private static IEnumerable<User> _listaVolun;
        private static Seguimiento _seguimiento;
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
            filtrado = filter;
            ViewData["filter"] = filter;
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        public async Task<IActionResult> Asignar(int id)
        {
            idSeguimiento = id;
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestVolun = new RestRequest("api/Seguimiento/GetAllVoluntarios/", Method.GET);
            var responseVolun = await client.ExecuteAsync<IEnumerable<User>>(requestVolun);
            if (!responseVolun.IsSuccessful)
                throw new Exception();
            _listaVolun = responseVolun.Data;

            var requestSeg = new RestRequest("api/Seguimiento/GetSeguimiento/" + id, Method.GET);
            var responseSeg = await client.ExecuteAsync<Seguimiento>(requestSeg);
            if (!responseSeg.IsSuccessful)
                throw new Exception();
            _seguimiento = responseSeg.Data;
            var tupleModel = new Tuple<IEnumerable<User>, Seguimiento>(responseVolun.Data, responseSeg.Data);
            return View(tupleModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AsignarSeguimiento(int idUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestUserVolun = new RestRequest("api/Seguimiento/" + idSeguimiento + "/AsignarSeguimiento/" + idUser, Method.PUT);
            try
            {
                var responseUser = await client.ExecuteAsync<IEnumerable<User>>(requestUserVolun);
                if (!responseUser.IsSuccessful)
                    throw new Exception(responseUser.Content);
                TempData["alertsuccess"] = "Usuario asignado correctamente.";
                return Json(new { isValid = true, url = Url.Action("Lista", "Seguimiento", new { area = "AdministracionSeguimientos" }) });
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
        public async Task<IActionResult> QuitarAsignacion(int idUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestUserVolun = new RestRequest("api/Seguimiento/" + idSeguimiento + "/QuitarAsignacion/" + idUser, Method.PUT);
            try
            {
                var responseUser = await client.ExecuteAsync<IEnumerable<User>>(requestUserVolun);
                if (!responseUser.IsSuccessful)
                    throw new Exception(responseUser.Content);
                TempData["alertsuccess"] = "Usuario desvinculado del seguimiento.";
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelarAsignacion(int idUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestUserVolun = new RestRequest("api/Seguimiento/" + idSeguimiento + "/QuitarAsignacion/" + idUser, Method.PUT);
            try
            {
                var responseUser = await client.ExecuteAsync<IEnumerable<User>>(requestUserVolun);
                if (!responseUser.IsSuccessful)
                    throw new Exception(responseUser.Content);
                TempData["alertsuccess"] = "Se ha cancelado la solicitud de asignación.";
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
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var requestGet = new RestRequest("api/Seguimiento/GetAllSeguimiento", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
                var response = await client.ExecuteAsync<IEnumerable<Seguimiento>>(requestGet);
                if (response.ResponseStatus.Equals(ResponseStatus.Error))
                    throw new Exception();
                var header = response.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
                var head = JObject.Parse(header.Value.ToString());
                ViewData["currentPage"] = head["currentPage"].ToString();
                ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
                ViewData["totalItems"] = head["totalItems"].ToString();
                ViewData["totalPages"] = head["totalPages"].ToString();
                var vista = response.Data;
                return vista;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task<IActionResult> ExcelSeguimientos()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Seguimiento/GetAll", Method.GET);
                var response = await client.ExecuteAsync<IEnumerable<Seguimiento>>(request);
                var content = ReportSeguimientoReporte.ExcelSeguimientos(response.Data);
                return File(
                    content,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "Seguimientos.xlsx");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task<IActionResult> ExcelReportes()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteSeguimiento/GetAll", Method.GET);
                var response = await client.ExecuteAsync<IEnumerable<ReporteSeguimiento>>(request);
                var content = ReportSeguimientoReporte.ExcelReportes(response.Data);
                return File(
                    content,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "SeguimientoReportes.xlsx");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
