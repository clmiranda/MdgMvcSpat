﻿using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Threading.Tasks;
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionMascotas.Controllers
{
    [Area("AdministracionMascotas")]
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class ReporteTratamientoController : Controller
    {
        private static int idMascota = 0;
        [Route("ReporteTratamiento/Lista/{id}")]
        public async Task<IActionResult> Lista(int id)
        {
            idMascota = id;
            var vista = await ListadoReporteTratamientos();
            return View(vista);
        }
        [Route("ReporteTratamiento/Detalle/{id}")]
        public async Task<IActionResult> Detalle(int id)
        {
            idMascota = id;
            var vista = await ListadoReporteTratamientos();
            return View(vista);
        }
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEditReporteTratamiento(int idmascota, int id = 0)
        {
            idMascota = idmascota;
            if (id == 0)
                return View(new ReporteTratamiento { MascotaId = idMascota });
            else
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteTratamiento/GetReporteTratamiento/" + id, Method.GET);
                try
                {
                    var response = await APIConnection.client.ExecuteAsync<ReporteTratamiento>(request);
                    if (!response.IsSuccessful)
                        throw new Exception();

                    return View(response.Data);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFecha(int id, DateTime FechaReporteTratamiento, int mascotaId)
        {
            idMascota = mascotaId;
            try
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteTratamiento/UpdateFecha", Method.PUT).AddParameter("Id", id).AddParameter("FechaCreacion", FechaReporteTratamiento);
                var response = await APIConnection.client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Fecha actualizada exitosamente.";
                var vista = await ListadoReporteTratamientos();
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                var vista = await ListadoReporteTratamientos();
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditReporteTratamiento(ReporteTratamiento model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/ReporteTratamiento/CreateReporteTratamiento/", Method.POST).AddJsonBody(model);
                    try
                    {
                        var response = await APIConnection.client.ExecuteAsync(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Reporte de tratamiento creado.";
                        var vista = await ListadoReporteTratamientos();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new { isValid = false });
                    }
                }
                else
                {
                    APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/ReporteTratamiento/UpdateReporteTratamiento/", Method.PUT).AddJsonBody(model);
                    try
                    {
                        var response = await APIConnection.client.ExecuteAsync(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Reporte de tratamiento actualizado.";
                        var vista = await ListadoReporteTratamientos();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new { isValid = false });
                    }
                }
            }
            return Json(new { isValid = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteReporteTratamiento(int id)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ReporteTratamiento/DeleteReporteTratamiento/" + id, Method.DELETE);
            try
            {
                var response = await APIConnection.client.ExecuteAsync<Denuncia>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Reporte de tratamiento eliminado.";
                var vista = await ListadoReporteTratamientos();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { isValid = false });
            }
        }
        public async Task<Mascota> ListadoReporteTratamientos()
        {
            try
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ReporteTratamiento/GetAllReporteTratamiento/" + idMascota, Method.GET);
                var response = await APIConnection.client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                var vista = response.Data;
                return vista;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}