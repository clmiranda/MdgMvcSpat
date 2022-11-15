using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Threading.Tasks;
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionSeguimientos.Controllers
{
    [Area("AdministracionSeguimientos")]
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class ReporteSeguimientoController : Controller
    {
        private static Seguimiento _seguimiento;
        [Route("ReporteSeguimiento/Lista/{id}")]
        public async Task<IActionResult> Lista(int id)
        {
            try
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Seguimiento/GetSeguimiento/" + id, Method.GET);
                var response = await APIConnection.client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                _seguimiento = response.Data;
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [NoDirectAccess]
        public async Task<IActionResult> SetRangoFechasSeguimiento(int id = 0)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Seguimiento/GetSeguimiento/" + id, Method.GET);
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
        [NoDirectAccess]
        public IActionResult GetFotoReporteSeguimiento(string url="") {
            return PartialView("GetFotoReporteSeguimiento", url);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateRangoFechasSeguimiento(Seguimiento modelo)
        {
            if (ModelState.IsValid)
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteSeguimiento/UpdateRangoFechasSeguimiento/", Method.PUT).AddJsonBody(modelo);
                try
                {
                    var response = await APIConnection.client.ExecuteAsync<Seguimiento>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Rango de fechas actualizada.";
                    _seguimiento = response.Data;
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", response.Data) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                    return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "SetRangoFechasSeguimiento", modelo) });
                }
            }
            return Json(new { isValid = false});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFechaReporte(ReporteSeguimiento reporteSeguimiento)
        {
            ModelState.Clear();
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/UpdateFechaReporte/", Method.PUT).AddJsonBody(reporteSeguimiento);
            try
            {
                var response = await APIConnection.client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Fecha actualizada.";
                _seguimiento = response.Data;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", _seguimiento) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReporte(int id)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/CreateReporteSeguimiento/" + id, Method.POST);
            try
            {
                var response = await APIConnection.client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Reporte creado.";
                _seguimiento = response.Data;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", _seguimiento) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteReporte(int idReporte, int idSeguimiento)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteSeguimiento/" + idSeguimiento + "/DeleteReporte/" + idReporte, Method.DELETE);
            try
            {
                var response = await APIConnection.client.ExecuteAsync<Seguimiento>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Reporte eliminado.";
                _seguimiento = response.Data;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", _seguimiento) });
            }
        }
    }
}
