using DATA.DTOs;
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
    public class SeguimientoAsignadoController : Controller
    {
        private static List<Seguimiento> _listaSeguimientos;
        private static int? pagesize = 10; private int? pagenumber = 1;
        [Route("SeguimientoAsignado/Lista")]
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
        [Route("SeguimientoAsignado/ListaReportes/{id}")]
        public async Task<IActionResult> ListaReportes(int id)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/GetSeguimientoForVoluntario/" + id, Method.GET);
            try
            {
                var response = await APIConnection.client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [Route("SeguimientoAsignado/Detalle/{id}")]
        public async Task<IActionResult> Detalle(int id)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Adopcion/GetById/" + id, Method.GET);
            try
            {
                var response = await APIConnection.client.ExecuteAsync<SolicitudAdopcion>(request);
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
        public async Task<IActionResult> SendReporte(ReporteSeguimientoDto reporteSeguimientoDto)
        {
            if (ModelState.IsValid)
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteSeguimiento/SendReporte", Method.PUT).AddParameter("Id", reporteSeguimientoDto.Id).AddParameter("SeguimientoId", reporteSeguimientoDto.SeguimientoId).AddParameter("Observaciones", reporteSeguimientoDto.Observaciones);
                using (var stream = new MemoryStream())
                {
                    request.Files.Add(new FileParameter
                    {
                        Name = "Foto",
                        Writer = (s) =>
                        {
                            reporteSeguimientoDto.Foto.CopyTo(s);
                        },
                        FileName = reporteSeguimientoDto.Foto.FileName,
                        ContentType = reporteSeguimientoDto.Foto.ContentType,
                        ContentLength = reporteSeguimientoDto.Foto.Length
                    });
                }
                try
                {
                    var response = await APIConnection.client.ExecuteAsync<Seguimiento>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "El reporte fue enviado exitosamente.";
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
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "EditReporte", reporteSeguimientoDto) });
        }

        [NoDirectAccess]
        public async Task<IActionResult> EditReporte(int id)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/GetById/" + id, Method.GET);
            try
            {
                var response = await APIConnection.client.ExecuteAsync<ReporteSeguimientoDto>(request);
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
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var requestGet = new RestRequest("api/Seguimiento/GetAllSeguimientoVoluntario", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize);
                var response = await APIConnection.client.ExecuteAsync<List<Seguimiento>>(requestGet);
                if (!response.IsSuccessful)
                    throw new Exception();
                var header = response.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
                var head = JObject.Parse(header.Value.ToString());
                ViewData["currentPage"] = head["currentPage"].ToString();
                ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
                ViewData["totalItems"] = head["totalItems"].ToString();
                ViewData["totalPages"] = head["totalPages"].ToString();
                var vista = response.Data;
                _listaSeguimientos = vista;
                return vista;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}