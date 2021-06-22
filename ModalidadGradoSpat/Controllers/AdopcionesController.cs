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

namespace ModalidadGradoSpat.Controllers
{
    [AllowAnonymous]
    public class AdopcionesController : Controller
    {
        private static RestClient client;
        private static int? pagesize = 10; private static int? pagenumber = 1; private static string filtrado = "Adopcion";
        public AdopcionesController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Inicio()
        {
            ViewData["filter"] = "Adopcion";
            var vista = await Listado();
            return View(vista);
        }
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
        public async Task<IActionResult> InformacionMascota(int id)
        {
            try
            {
                var request = new RestRequest("api/Mascota/GetMascota/" + id, Method.GET);
                var response = await client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task<IActionResult> ContratoAdopcion(int id)
        {
            try
            {
                var request = new RestRequest("api/ContratoAdopcion/GetContratoByIdMascota/" + id, Method.GET);
                var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                TempData["MascotaId"] = id;
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostContrato(ContratoAdopcion modelo)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ContratoAdopcion/GenerarContrato", Method.POST).AddJsonBody(modelo);
                try
                {
                    var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Contrato enviado, nos comunicaremos con usted en caso de cumplir los requisitos.";
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ContratoAdopcion", response.Data) });
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
                var request = new RestRequest("api/Mascota/GetAllMascotaAdopcion", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
                var response = await client.ExecuteAsync<List<Mascota>>(request);
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
