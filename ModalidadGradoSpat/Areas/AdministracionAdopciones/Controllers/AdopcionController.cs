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

namespace ModalidadGradoSpat.Areas.AdministracionAdopciones.Controllers
{
    [Area("AdministracionAdopciones")]
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class AdopcionController : Controller
    {
        private static RestClient client;
        private static List<SolicitudAdopcion> _listaPDF;
        private static int? pagesize = 10; private static int? pagenumber = 1; private static string filtrado = "Pendiente";
        private static SolicitudAdopcion _solicitudAdopcion = new SolicitudAdopcion();
        public AdopcionController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [Route("Adopcion/Lista")]
        public async Task<IActionResult> Lista()
        {
            ViewData["filter"] = filtrado;
            var vista = await Listado();
            _listaPDF = await ListadoPDF();
            ViewData["ListaSolicitudes"] = _listaPDF;
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string filter = "Pendiente")
        {
            pagesize = sizePage;
            pagenumber = currentPage;
            filtrado = filter;
            ViewData["filter"] = filter;
            var vista = await Listado();
            ViewData["ListaSolicitudes"] = _listaPDF;
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        [NoDirectAccess]
        public IActionResult AddSolicitudAdopcionRechazada(int id)
        {
            return View(new AdopcionRechazada { SolicitudAdopcionId = id });
        }
        [NoDirectAccess]
        public IActionResult AddAdopcionCancelada(int id)
        {
            return View(new AdopcionCancelada { SolicitudAdopcionId = id });
        }
        [Route("Adopcion/Detalle/{id}")]
        public async Task<IActionResult> Detalle(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Adopcion/GetById/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<SolicitudAdopcion>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                _solicitudAdopcion = response.Data;
                return View(_solicitudAdopcion);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFecha(int id, DateTime FechaAdopcion)
        {
            ViewData["filter"] = filtrado;
            ViewData["ListaSolicitudes"] = _listaPDF;
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Adopcion/UpdateFecha", Method.PUT).AddParameter("Id", id).AddParameter("FechaAdopcion", FechaAdopcion);
                var response = await client.ExecuteAsync<SolicitudAdopcion>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Fecha actualizada exitosamente.";
                var vista = await Listado();
                ViewData["ListaSolicitudes"] = _listaPDF;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                var vista = await Listado();
                ViewData["ListaSolicitudes"] = _listaPDF;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AprobarSolicitudAdopcion(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Adopcion/" + id + "/AprobarSolicitudAdopcion", Method.PUT);
            try
            {
                var response = await client.ExecuteAsync<SolicitudAdopcion>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "La solicitud de adopción se ha aprobado correctamente, se ha creado el seguimiento respectivo.";
                return Json(new { isValid = true, url = Url.Action("Lista", "Adopcion", new { area = "AdministracionAdopciones" }) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "PartialView/_AdministrarSolicitudAdopcion", _solicitudAdopcion) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RechazarSolicitudAdopcion(AdopcionRechazada rechazada)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Adopcion/RechazarSolicitudAdopcion", Method.PUT).AddJsonBody(rechazada);
                try
                {
                    var response = await client.ExecuteAsync<SolicitudAdopcion>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Solicitud de adopción rechazada, se ha creado un nuevo informe.";
                    return Json(new { isValid = true, url = Url.Action("Lista", "Adopcion", new { area = "AdministracionAdopciones" }) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                    return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddSolicitudAdopcionRechazada", rechazada) });
                }
            }
            return Json(new { isValid = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelarAdopcion(AdopcionCancelada cancelada)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Adopcion/CancelarAdopcion", Method.PUT).AddJsonBody(cancelada);
                try
                {
                    var response = await client.ExecuteAsync<SolicitudAdopcion>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Adopción cancelada, se ha creado un nuevo informe.";
                    return Json(new { isValid = true, url = Url.Action("Lista", "Adopcion", new { area = "AdministracionAdopciones" }) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                    return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddAdopcionCancelada", cancelada) });
                }
            }
            return Json(new { isValid = false });
        }
        public async Task<List<SolicitudAdopcion>> Listado()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Adopcion/GetAllAdopciones", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
                var response = await client.ExecuteAsync<List<SolicitudAdopcion>>(request);
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
        public async Task<List<SolicitudAdopcion>> ListadoPDF()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Adopcion/GetAllAdopcionesForReport", Method.GET);
            try
            {
                var response = await client.ExecuteAsync<List<SolicitudAdopcion>>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return response.Data;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public IActionResult ExcelAdopcionesAprobadas()
        {
            var listaSolicitudesAprobadas = _listaPDF.Where(x => x.Estado.Equals("Aprobado"));
            var content = ReportAdopcion.ExcelAdopciones(listaSolicitudesAprobadas);
            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "AdopcionesAprobadas.xlsx");
        }
        public IActionResult ExcelSolicitudesAdopcionRechazadas()
        {
            var listaSolicitudesRechazadas = _listaPDF.Where(x => x.Estado.Equals("Rechazado")).ToList().ConvertAll(x => x.AdopcionRechazada);
            var content = ReportAdopcion.ExcelAdopcionesRechazadas(listaSolicitudesRechazadas);
            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "AdopcionesRechazadas.xlsx");
        }
        public IActionResult ExcelAdopcionesCanceladas()
        {
            var listaSolicitudesCanceladas = _listaPDF.Where(x => x.Estado.Equals("Cancelado")).ToList().ConvertAll(x => x.AdopcionCancelada);
            var content = ReportAdopcion.ExcelAdopcionesCanceladas(listaSolicitudesCanceladas);
            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "AdopcionesCanceladas.xlsx");
        }
    }
}