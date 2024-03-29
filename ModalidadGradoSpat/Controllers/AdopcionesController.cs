﻿using DATA.DTOs;
using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Controllers
{
    [AllowAnonymous]
    public class AdopcionesController : Controller
    {
        private static int? pagesize = 9; private int? pagenumber = 1; private static string filtrado = "Adopcion";
        public async Task<IActionResult> Inicio()
        {
            ViewData["filter"] = filtrado;
            var vista = await Listado();
            return View(vista);
        }
        [Route("QuienesSomos")]
        public IActionResult QuienesSomos()
        {
            return View();
        }
        public async Task<IActionResult> LeyMunicipal()
        {
            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot/archivos/ley/Ley 217.docx");

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/vnd.ms-word", Path.GetFileName(path));
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string filter = "Adopcion")
        {
            pagesize = sizePage;
            pagenumber = currentPage;
            filtrado = filter;
            ViewData["filter"] = filter;
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Inicio", vista));
        }
        [Route("InformacionMascota/{id}")]
        public async Task<IActionResult> InformacionMascota(int id)
        {
            try
            {
                var request = new RestRequest("api/Mascota/GetMascota/" + id, Method.GET);
                var response = await APIConnection.client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [Route("FomularioSolicitudAdopcion/{id}")]
        public async Task<IActionResult> FomularioSolicitudAdopcion(int id)
        {
            try
            {
                var request = new RestRequest("api/Adopcion/GetSolicitudAdopcionByIdMascota/" + id, Method.GET);
                var response = await APIConnection.client.ExecuteAsync<SolicitudAdopcionDto>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                TempData["MascotaId"] = id;
                if (response.Data == null)
                    return View(null);
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSolicitudAdopcion(SolicitudAdopcion modelo)
        {
            if (ModelState.IsValid)
            {
                var request = new RestRequest("api/Adopcion/CreateSolicitudAdopcion", Method.POST).AddJsonBody(modelo);
                try
                {
                    var response = await APIConnection.client.ExecuteAsync<SolicitudAdopcion>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Solicitud de adopción enviada correctamente, nos comunicaremos con usted en caso de ser apto para la adopción.";
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_FomularioSolicitudAdopcion", response.Data) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { isValid = false });
        }
        public async Task<List<Mascota>> Listado()
        {
            try
            {
                var request = new RestRequest("api/Mascota/GetAllMascotasForAdopcion", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
                var response = await APIConnection.client.ExecuteAsync<List<Mascota>>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                var header = response.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
                var head = JObject.Parse(header.Value.ToString());
                ViewData["currentPage"] = head["currentPage"].ToString();
                ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
                ViewData["totalItems"] = head["totalItems"].ToString();
                ViewData["totalPages"] = head["totalPages"].ToString();
                return response.Data;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}