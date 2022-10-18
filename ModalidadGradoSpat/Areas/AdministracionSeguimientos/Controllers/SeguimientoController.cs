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
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionSeguimientos.Controllers
{
    [Area("AdministracionSeguimientos")]
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class SeguimientoController : Controller
    {
        private RestClient client;
        private static List<User> _listaVoluntarios;
        private static Seguimiento _seguimiento;
        private static int idSeguimiento;
        private static List<Seguimiento> _listaSeguimientos;
        private int? pagesize = 10; private int? pagenumber = 1; private string filtrado = "Activo";
        public SeguimientoController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [Route("Seguimiento/Lista")]
        public async Task<IActionResult> Lista()
        {
            ViewData["filter"] = filtrado;
            var vista = await Listado();
            _listaSeguimientos = await ListadoPDF();
            ViewData["ListaSeguimientos"] = _listaSeguimientos;
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string filter = "Activo")
        {
            pagesize = sizePage;
            pagenumber = currentPage;
            filtrado = filter;
            ViewData["filter"] = filter;
            var vista = await Listado();
            ViewData["ListaSeguimientos"] = _listaSeguimientos;
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        [Route("Seguimiento/Detalle/{idSolicitudAdopcion}")]
        public async Task<IActionResult> Detalle(int idSolicitudAdopcion)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Adopcion/GetById/" + idSolicitudAdopcion, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<SolicitudAdopcion>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [Route("Seguimiento/AsignarSeguimiento/{idseguimiento}")]
        public async Task<IActionResult> AsignarSeguimiento(int idseguimiento)
        {
            idSeguimiento = idseguimiento;
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            try
            {
                var requestVoluntario = new RestRequest("api/Seguimiento/GetAllVoluntarios/", Method.GET);
                var responseVoluntario = await client.ExecuteAsync<List<User>>(requestVoluntario);
                if (!responseVoluntario.IsSuccessful)
                    throw new Exception();
                _listaVoluntarios = responseVoluntario.Data;

                var requestSeg = new RestRequest("api/Seguimiento/GetSeguimiento/" + idseguimiento, Method.GET);
                var responseSeg = await client.ExecuteAsync<Seguimiento>(requestSeg);
                if (!responseSeg.IsSuccessful)
                    throw new Exception();
                _seguimiento = responseSeg.Data;
                var tupleModel = new Tuple<List<User>, Seguimiento>(responseVoluntario.Data, responseSeg.Data);
                return View(tupleModel);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Asignar(int idUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestUserVolun = new RestRequest("api/Seguimiento/" + idSeguimiento + "/AsignarSeguimiento/" + idUser, Method.PUT);
            try
            {
                var responseUser = await client.ExecuteAsync/*<List<User>>*/(requestUserVolun);
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
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "PartialView/_AsignarSeguimiento", new Tuple<List<User>, Seguimiento>(_listaVoluntarios, _seguimiento)) });
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
                var responseUser = await client.ExecuteAsync<List<User>>(requestUserVolun);
                if (!responseUser.IsSuccessful)
                    throw new Exception(responseUser.Content);
                TempData["alertsuccess"] = "Usuario desvinculado del seguimiento.";
                var requestSeguimiento = new RestRequest("api/Seguimiento/GetSeguimiento/" + idSeguimiento, Method.GET);
                var responseSeguimiento = await client.ExecuteAsync<Seguimiento>(requestSeguimiento);
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_AsignarSeguimiento", new Tuple<List<User>, Seguimiento>(responseUser.Data, responseSeguimiento.Data)) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_AsignarSeguimiento", new Tuple<List<User>, Seguimiento>(_listaVoluntarios, _seguimiento)) });
            }
        }
        public async Task<List<Seguimiento>> Listado()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var requestGet = new RestRequest("api/Seguimiento/GetAllSeguimiento", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
                var response = await client.ExecuteAsync<List<Seguimiento>>(requestGet);
                if (!response.IsSuccessful)
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
        public async Task<List<Seguimiento>> ListadoPDF()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/GetAllSeguimientosForReport", Method.GET);
            try
            {
                var response = await client.ExecuteAsync<List<Seguimiento>>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return response.Data;
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
                var request = new RestRequest("api/Seguimiento/GetAllSeguimientosForReport", Method.GET);
                var response = await client.ExecuteAsync<List<Seguimiento>>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
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
                var request = new RestRequest("api/ReporteSeguimiento/GetAllReporteSeguimientosForReport", Method.GET);
                var response = await client.ExecuteAsync<List<ReporteSeguimiento>>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
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
