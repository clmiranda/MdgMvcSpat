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
    public class ReporteSeguimientoController : Controller
    {
        private static RestClient client;
        private static Seguimiento _seguimiento;
        //private static int idSeguimiento;
        public ReporteSeguimientoController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> ListaReportes(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/GetSeguimiento/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                {
                    switch (response.StatusCode.ToString())
                    {
                        case "BadRequest":
                            return StatusCode(400);
                        case "NotFound":
                            return StatusCode(404);
                        default:
                            throw new Exception();
                    }
                }
                _seguimiento = response.Data;
                return View(response.Data);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        //[NoDirectAccess]
        //public async Task<IActionResult> EditReporte(int id = 0)
        //{
        //    //var resul = await restReporte.GetAsync(id, "api/ReporteSeguimiento/" + id + "/GetById/", HttpContext.Session.GetString("JWToken"));
        //    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
        //    var request = new RestRequest("api/ReporteSeguimiento/GetById/"+ id, Method.GET);
        //    var response = await client.ExecuteAsync<ReporteSeguimiento>(request);
        //    return View(response.Data);
        //}
        [NoDirectAccess]
        public async Task<IActionResult> EditSeguimiento(int id = 0)
        {
            //var resul = await rest.GetAsync(id, "api/Seguimiento/GetSeguimiento/" + id, HttpContext.Session.GetString("JWToken"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/GetSeguimiento/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                {
                    switch (response.StatusCode.ToString())
                    {
                        case "BadRequest":
                            return StatusCode(400);
                        case "NotFound":
                            return StatusCode(404);
                        default:
                            throw new Exception();
                    }
                }
                return View(response.Data);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveSeguimiento(Seguimiento modelo)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Seguimiento/UpdateFecha/", Method.PUT).AddJsonBody(modelo);
                try
                {
                    //var resul = await rest.PutAsync(modelo, "api/Seguimiento/UpdateFecha");
                    var response = await client.ExecuteAsync<Seguimiento>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    //ViewData["filter"] = filtrado;
                    TempData["alertsuccess"] = "Rango de fecha actualizada.";
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", response.Data) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                    return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "EditSeguimiento", modelo) });
                }
            }
            return Json(new { isValid = false/*, html = Helper.RenderRazorViewToString(this, "EditSeguimiento", modelo)*/ });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveFecha(ReporteSeguimiento modelo)
        {
            ModelState.Clear();
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/SaveReporteSeguimientoAdmin", Method.PUT).AddJsonBody(modelo);
            try
            {
                //var resul = await restReporte.PutAsync(modelo, "api/ReporteSeguimiento/SaveReporteSeguimientoAdmin");
                var response = await client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Fecha actualizada.";
                _seguimiento = response.Data;
                return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { /*isValid = false, */html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", _seguimiento) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReporte(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/CreateReporteSeguimiento/" + id, Method.POST);
            try
            {
                var response = await client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Reporte creado.";
                //ViewData["id"] = idSeguimiento;
                _seguimiento = response.Data;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", _seguimiento) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteReporte(int id, int idseg)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/" + idseg + "/DeleteReporte/" + id, Method.DELETE);
            try
            {
                var response = await client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Reporte eliminado.";
                //ViewData["id"] = idSeguimiento;
                _seguimiento = response.Data;
                return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { /*isValid = false */ html = Helper.RenderRazorViewToString(this, "PartialView/_ListaReportes", _seguimiento) });
            }
        }
    }
}
