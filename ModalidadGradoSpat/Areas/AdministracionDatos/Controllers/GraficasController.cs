using DATA.DTOs.Graficas;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Areas.AdministracionDatos.Controllers
{
    [Area("AdministracionDatos")]
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class GraficasController : Controller
    {
        private RestClient client;
        private string fechaInicio = DateTime.Now.AddMonths(-3).ToShortDateString();
        private string fechaFin = DateTime.Now.ToShortDateString();
        public GraficasController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [Route("Grafica/Adopciones")]
        public async Task<IActionResult> Adopciones()
        {
            ViewData["fechaInicio"] = fechaInicio;
            ViewData["fechaFin"] = fechaFin;
            var vista = await ListadoAdopciones(new string[] { fechaInicio, fechaFin });
            return View(vista);
        }
        public async Task<List<DataGraficaDto>> ListadoAdopciones(string[] fechas)
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Graficas/GetGraficasAdopciones", Method.POST).AddJsonBody(fechas);
                var response = await client.ExecuteAsync<List<DataGraficaDto>>(request);
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
        public async Task<IActionResult> ReturnVistaAdopciones(string[] fechas)
        {
            fechaInicio = fechas[0];
            fechaFin = fechas[1];
            ViewData["fechaInicio"] = fechaInicio;
            ViewData["fechaFin"] = fechaFin;
            try
            {
                var vista = await ListadoAdopciones(fechas);
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Adopciones", vista) });
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [Route("Grafica/Mascotas")]
        public async Task<IActionResult> Mascotas()
        {
            ViewData["fechaInicio"] = fechaInicio;
            ViewData["fechaFin"] = fechaFin;
            var vista = await ListadoMascotas(new string[] { fechaInicio, fechaFin });
            return View(vista);
        }
        public async Task<List<DataGraficaDto>> ListadoMascotas(string[] fechas)
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Graficas/GetGraficasMascotas", Method.POST).AddJsonBody(fechas);
                var response = await client.ExecuteAsync<List<DataGraficaDto>>(request);
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
        public async Task<IActionResult> ReturnVistaMascotas(string[] fechas)
        {
            fechaInicio = fechas[0];
            fechaFin = fechas[1];
            ViewData["fechaInicio"] = fechaInicio;
            ViewData["fechaFin"] = fechaFin;
            try
            {
                var vista = await ListadoMascotas(fechas);
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Mascotas", vista) });
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [Route("Grafica/ReporteSeguimientos")]
        public async Task<IActionResult> ReporteSeguimientos()
        {
            ViewData["fechaInicio"] = fechaInicio;
            ViewData["fechaFin"] = fechaFin;
            var vista = await ListadoReporteSeguimientos(new string[] { fechaInicio, fechaFin });
            return View(vista);
        }
        public async Task<List<DataGraficaDto>> ListadoReporteSeguimientos(string[] fechas)
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Graficas/GetGraficasReporteSeguimientos", Method.POST).AddJsonBody(fechas);
                var response = await client.ExecuteAsync<List<DataGraficaDto>>(request);
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
        public async Task<IActionResult> ReturnVistaReporteSeguimientos(string[] fechas)
        {
            fechaInicio = fechas[0];
            fechaFin = fechas[1];
            ViewData["fechaInicio"] = fechaInicio;
            ViewData["fechaFin"] = fechaFin;
            try
            {
                var vista = await ListadoReporteSeguimientos(fechas);
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ReporteSeguimientos", vista) });
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
