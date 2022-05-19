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
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionMascotas.Controllers
{
    [Area("AdministracionMascotas")]
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class DenunciaController : Controller
    {
        private static RestClient client;
        private static List<Denuncia> _listaPDF;
        private static int? sizepage = 10; private static int? pagenumber = 1; private static string busqueda = "";
        public DenunciaController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [Route("Denuncia/Lista")]
        public async Task<IActionResult> Lista()
        {
            ViewData["search"] = busqueda;
            var vista = await Listado();
            _listaPDF = await ListadoPDF();
            ViewData["ListaDenuncias"] = _listaPDF;
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string search = "")
        {
            pagenumber = currentPage;
            busqueda = search;
            sizepage = sizePage;
            ViewData["search"] = search;
            var vista = await Listado();
            ViewData["ListaDenuncias"] = _listaPDF;
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEditDenuncia(int id = 0)
        {
            if (id == 0)
                return View(new Denuncia());
            else
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Denuncia/GetDenuncia/" + id, Method.GET);
                try
                {
                    var response = await client.ExecuteAsync<Denuncia>(request);
                    if (!response.IsSuccessful)
                    {
                        throw new Exception();
                    }
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
        public async Task<IActionResult> AddOrEditDenuncia(Denuncia model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/Denuncia/CreateDenuncia/", Method.POST).AddJsonBody(model);
                    try
                    {
                        var response = await client.ExecuteAsync<Denuncia>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Denuncia creada.";
                        ViewData["search"] = busqueda;
                        var vista = await Listado();
                        ViewData["ListaDenuncias"] = _listaPDF;
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEditDenuncia", model) });
                    }
                }
                else
                {
                    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/Denuncia/UpdateDenuncia/", Method.PUT).AddJsonBody(model);
                    try
                    {
                        var response = await client.ExecuteAsync<Denuncia>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Denuncia actualizada.";
                        ViewData["search"] = busqueda;
                        var vista = await Listado();
                        ViewData["ListaDenuncias"] = _listaPDF;
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEditDenuncia", model) });
                    }
                }
            }
            return Json(new { isValid = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDenuncia(int id)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Denuncia/DeleteDenuncia/" + id, Method.DELETE);
            ViewData["search"] = busqueda;
            ViewData["ListaDenuncias"] = _listaPDF;
            try
            {
                var response = await client.ExecuteAsync<Denuncia>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "La denuncia fue eliminada de manera exitosa";
                var vista = await Listado();
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                var vista = await Listado();
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
        }
        public async Task<List<Denuncia>> Listado()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var requestGet = new RestRequest("api/Denuncia/GetAllDenuncias", Method.GET).AddParameter("Busqueda", busqueda).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", sizepage);
                var response = await client.ExecuteAsync<List<Denuncia>>(requestGet);
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
        public async Task<List<Denuncia>> ListadoPDF()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Denuncia/GetAllDenunciasForReport", Method.GET);
            try
            {
                var response = await client.ExecuteAsync<List<Denuncia>>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return response.Data;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task<IActionResult> ExcelDenuncias()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Denuncia/GetAllDenunciasForReport", Method.GET);
            try
            {
                var response = await client.ExecuteAsync<List<Denuncia>>(request);
                if (!response.IsSuccessful)
                {
                    throw new Exception();
                }
                var content = ReportDenuncia.ExcelDenuncias(response.Data);
                return File(
                            content,
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                            "Denuncias.xlsx");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
