﻿using DATA.DTOs.Graficas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Areas.AdministracionSeguimientos.Controllers
{
    public class GraficasController : Controller
    {
        private static RestClient client;
        private string filtro = "3 meses";
        public GraficasController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Adopciones()
        {
            ViewData["filter"] = filtro;
            var vista = await ListadoAdopciones();
            return View(vista);
        }
        public async Task<List<DataGraficaDto>> ListadoAdopciones()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Graficas/GetGraficasAdopciones", Method.GET).AddParameter("filtro", filtro);
            var response = await client.ExecuteAsync<List<DataGraficaDto>>(request);
            if (response.ResponseStatus.Equals(ResponseStatus.Error))
                throw new Exception();
            var vista = response.Data;
            return vista;
        }
        public async Task<IActionResult> ReturnVistaAdopciones(string filtrado)
        {
            filtro = filtrado;
            ViewData["filter"] = filtrado;
            var vista = await ListadoAdopciones();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Adopciones", vista));
        }


        public async Task<IActionResult> Mascotas()
        {
            ViewData["filter"] = filtro;
            var vista = await ListadoMascotas();
            return View(vista);
        }
        public async Task<List<DataGraficaDto>> ListadoMascotas()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Graficas/GetGraficasMascotas", Method.GET).AddParameter("filtro", filtro);
            var response = await client.ExecuteAsync<List<DataGraficaDto>>(request);
            if (response.ResponseStatus.Equals(ResponseStatus.Error))
                throw new Exception();
            var vista = response.Data;
            return vista;
        }
        public async Task<IActionResult> ReturnVistaMascotas(string filtrado)
        {
            filtro = filtrado;
            ViewData["filter"] = filtrado;
            var vista = await ListadoMascotas();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Mascotas", vista));
        }


        public async Task<IActionResult> ReporteSeguimientos()
        {
            ViewData["filter"] = filtro;
            var vista = await ListadoReporteSeguimientos();
            return View(vista);
        }
        public async Task<List<DataGraficaDto>> ListadoReporteSeguimientos()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Graficas/GetGraficasReporteSeguimientos", Method.GET).AddParameter("filtro", filtro);
            var response = await client.ExecuteAsync<List<DataGraficaDto>>(request);
            if (response.ResponseStatus.Equals(ResponseStatus.Error))
                throw new Exception();
            var vista = response.Data;
            return vista;
        }
        public async Task<IActionResult> ReturnVistaReporteSeguimientos(string filtrado)
        {
            filtro = filtrado;
            ViewData["filter"] = filtrado;
            var vista = await ListadoReporteSeguimientos();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_ReporteSeguimientos", vista));
        }
    }
}