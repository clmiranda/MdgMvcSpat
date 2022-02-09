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
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionSeguimientos.Controllers
{
    [Area("AdministracionSeguimientos")]
    [Authorize(Roles = "SuperAdministrador, Voluntario")]
    public class ReporteVoluntarioController : Controller
    {
        private static RestClient client;
        private static List<Seguimiento> _listaSeg;
        private static int? pagesize = 10; private static int? pagenumber = 1;
        public ReporteVoluntarioController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [Route("Voluntario/Reporte/Lista")]
        public async Task<IActionResult> Lista()
        {
            var vista = await Listado();
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1)
        {
            pagesize = sizePage;
            pagenumber = currentPage;
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        [Route("Voluntario/Reporte/ListaReportes/{id}")]
        public async Task<IActionResult> ListaReportes(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/GetSeguimientoVoluntario/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [Route("Voluntario/Reporte/Detalle/{id}")]
        public async Task<IActionResult> Detalle(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Adopcion/GetById/" + id, Method.GET);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendReporte(ReporteSeguimiento reporte, IFormFile Foto)
        {
            ModelState.Clear();
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteSeguimiento/SendReporte", Method.PUT).AddParameter("Id", reporte.Id).AddParameter("SeguimientoId", reporte.SeguimientoId).AddParameter("Observaciones", reporte.Observaciones);
                using (var stream = new MemoryStream())
                {
                    request.Files.Add(new FileParameter
                    {
                        Name = "Foto",
                        Writer = (s) =>
                        {
                            Foto.CopyTo(s);
                        },
                        FileName = Foto.FileName,
                        ContentType = Foto.ContentType,
                        ContentLength = Foto.Length
                    });
                }
                try
                {
                    var response = await client.ExecuteAsync<Seguimiento>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "El Reporte fue enviado exitosamente.";
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", response.Data) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "EditReporte", reporte) });
        }

        [NoDirectAccess]
        public async Task<IActionResult> EditReporte(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/GetById/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<ReporteSeguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task<List<Seguimiento>> Listado()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var requestGet = new RestRequest("api/Seguimiento/GetAllSeguimientoVoluntario", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize);
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
                _listaSeg = vista;
                return vista;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}