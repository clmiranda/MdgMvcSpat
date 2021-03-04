using DATA.Models;
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

namespace ModalidadGradoSpat.Areas.AdministracionSeguimientos.Controllers
{
    public class ReporteVoluntarioController : Controller
    {
        private static RestClient client;
        private static IEnumerable<Seguimiento> _listaSeg;
        private static int? pagesize = 10; private static int? pagenumber = 1; private static string filtrado = "Asignado";
        public ReporteVoluntarioController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Lista()
        {
            ViewData["filter"] = filtrado;
            var vista = await Listado();
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string filter = "Asignado")
        {
            pagesize = sizePage;
            pagenumber = currentPage;
            filtrado = filter;
            ViewData["filter"] = filter;
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Asignar(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/"+id+ "/AsignarSeguimiento", Method.POST);
            try
            {
                //var resul = await rest.PostAsync("api/Seguimiento/" + id + "/AsignarSeguimiento/", HttpContext.Session.GetString("JWToken"));
                var response = await client.ExecuteAsync<IEnumerable<Seguimiento>>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Se ha asignado el seguimiento.";
                ViewData["filter"] = filtrado;
                return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", response.Data) });
            }
            catch (Exception ex)
            {
                TempData["alerterror"] = ex.Message.ToString();
                return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", _listaSeg) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rechazar(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/" + id + "/RechazarSeguimiento", Method.POST);
            try
            {
                //var resul = await rest.PostAsync("api/Seguimiento/" + id + "/AsignarSeguimiento/", HttpContext.Session.GetString("JWToken"));
                var response = await client.ExecuteAsync<IEnumerable<Seguimiento>>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Se ha rechazado el seguimiento.";
                ViewData["filter"] = filtrado;
                return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", response.Data) });
            }
            catch (Exception ex)
            {
                TempData["alerterror"] = ex.Message.ToString();
                return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", _listaSeg) });
            }
        }
        public async Task<IActionResult> Detalle(int id)
        {
            //idSeguimiento = id;
            //var resul = await restReporte.GetAsync("api/ReporteSeguimiento/"+id+ "/GetReportesForVoluntario", HttpContext.Session.GetString("JWToken"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/GetSeguimiento/" + id, Method.GET);
            var response = await client.GetAsync<Seguimiento>(request);
            //var responseGet = await client.ExecuteGetAsync(requestGet);
            //var obj = JsonConvert.DeserializeObject<Seguimiento>(responseGet.Content);
            return View(response);
        }

        public async Task<IActionResult> DetalleSeguimiento(int id)
        {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ContratoAdopcion/DetailAdopcion/" + id, Method.GET);
                var response = await client.GetAsync<ContratoAdopcion>(request);
                return View(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendReporte(ReporteSeguimiento reporteSeguimiento)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteSeguimiento/UpdateReporteSeguimientoVoluntario", Method.POST).AddJsonBody(reporteSeguimiento);
                try
                {
                    //var resul = await restReporte.PutAsync(reporteSeguimiento, "api/ReporteSeguimiento/UpdateReporteSeguimientoVoluntario");
                    var response = await client.ExecuteAsync<ReporteSeguimiento>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "El Reporte fue enviado exitosamente.";
                    return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_EditarReporte", response.Data) });
                }
                catch (Exception ex)
                {
                    TempData["alerterror"] = ex.Message.ToString();
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "PartialView/_EditarReporte", reporteSeguimiento) });
        }

        public async Task<IActionResult> EditarReporte(int id)
        {
            //var modelo = await restReporte.GetAsync(id, "api/ReporteSeguimiento/" + id + "/GetById/", HttpContext.Session.GetString("JWToken"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestGet = new RestRequest("api/ReporteSeguimiento/GetById/" + id, Method.GET);
            var responseGet = await client.GetAsync<ReporteSeguimiento>(requestGet);
            return View(responseGet);
        }


        public async Task<IEnumerable<Seguimiento>> Listado()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestGet = new RestRequest("api/Seguimiento/ListVoluntarioSeguimientos", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
            var responseGet = await client.ExecuteAsync<IEnumerable<Seguimiento>>(requestGet);
            var header = responseGet.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
            var head = JObject.Parse(header.Value.ToString());
            ViewData["currentPage"] = head["currentPage"].ToString();
            ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
            ViewData["totalItems"] = head["totalItems"].ToString();
            ViewData["totalPages"] = head["totalPages"].ToString();
            var vista = responseGet.Data;
            _listaSeg = vista;
            return vista;
        }
    }
}
