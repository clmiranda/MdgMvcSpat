using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModalidadGradoSpat.Reports;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Areas.AdministracionMascotas.Controllers
{
    [Area("AdministracionMascotas")]
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class MascotaController : Controller
    {
        private static RestClient client;
        private static Mascota _mascota;
        private static List<Mascota> _listaMascota;
        private static int? pagesize = 10; private static int? pagenumber = 1; private static string busqueda = "";
        public MascotaController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [Route("Mascota/Lista")]
        public async Task<IActionResult> Lista()
        {
            ViewData["search"] = busqueda;
            var vista = await Listado();
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string search = "")
        {
            pagesize = sizePage; pagenumber = currentPage; busqueda = search;
            ViewData["search"] = search;
            var vista = await Listado();
            return Json(new {html= Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
        }
        [Route("Denuncia/EditMascota/{id}")]
        public async Task<IActionResult> EditMascota(int id)
        {
            ViewData["TokenBearer"] = HttpContext.Session.GetString("JWToken");
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Mascota/GetMascotaDenuncia/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception();

                if (response.Data != null)
                    _mascota = response.Data;
                else
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
        public async Task<IActionResult> SetFotoPrincipal(int id, int idfoto)
        {
            ViewData["TokenBearer"] = HttpContext.Session.GetString("JWToken");
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Fotos/Mascota/" + id + "/SetFotoPrincipalMascota/" + idfoto, Method.POST);
            try
            {
                var response = await client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Foto principal establecida.";
                _mascota = response.Data;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", _mascota) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFotoMascota(int idmascota, int idfoto)
        {
            ViewData["TokenBearer"] = HttpContext.Session.GetString("JWToken");
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Fotos/Mascota/" + idmascota + "/DeleteFotoMascota/" + idfoto, Method.DELETE);
            try
            {
                var response = await client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Foto eliminada exitosamente.";
                _mascota = response.Data;
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new {html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", _mascota) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditMascota(int id, Mascota model)
        {
            if (ModelState.IsValid)
            {
                ViewData["TokenBearer"] = HttpContext.Session.GetString("JWToken");
                if (id == 0)
                {
                    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/Mascota/CreateMascota/", Method.POST).AddJsonBody(model);
                    try
                    {
                        var response = await client.ExecuteAsync<Mascota>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Registrado correctamente.";
                        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_EditMascota", response.Data), html2 = Helper.RenderRazorViewToString(this, "PartialView/_Fotos",response.Data) });
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_EditMascota", model) });
                    }
                }
                else
                {
                    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/Mascota/UpdateMascota/", Method.PUT).AddJsonBody(model);
                    try
                    {
                        var response = await client.ExecuteAsync<Mascota>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Modificado Correctamente.";
                        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_EditMascota", response.Data)});
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_EditMascota", model) });
                    }
                }
            }
            return Json(new { isValid = false});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CambiarEstado(int id, string estado)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Mascota/ChangeStateSituacion/" + id, Method.PUT).AddJsonBody(estado);
            try
            {
                var response = await client.ExecuteAsync<string>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Estado actualizado correctamente.";
                ViewData["search"] = busqueda;
                var vista = await Listado();
                return Json(new { html= Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", _listaMascota) });
            }
        }
        public async Task<List<Mascota>> Listado()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var requestGet = new RestRequest("api/Mascota/GetAllMascotaAdmin", Method.GET).AddParameter("Busqueda", busqueda).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize);
                var response = await client.ExecuteAsync<List<Mascota>>(requestGet);
                if (response.ResponseStatus.Equals(ResponseStatus.Error))
                    throw new Exception();
                var header = response.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
                var head = JObject.Parse(header.Value.ToString());
                ViewData["currentPage"] = head["currentPage"].ToString();
                ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
                ViewData["totalItems"] = head["totalItems"].ToString();
                ViewData["totalPages"] = head["totalPages"].ToString();
                var vista = response.Data;
                _listaMascota = response.Data;
                return vista;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task<IActionResult> ExcelMascotas()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Mascota/GetAll", Method.GET);
            try
            {
                var response = await client.ExecuteAsync<List<Mascota>>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                var content = ReportMascota.ExcelMascotas(response.Data);
                return File(
                    content,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "Mascotas.xlsx");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
