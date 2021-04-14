using ClosedXML.Excel;
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
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionMascotas.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class DenunciaController : Controller
    {
        private static RestClient client;
        //private static Mascota mascota;
        private static int? sizepage = 10; private static int? pagenumber = 1; private static string busqueda = "";
        public DenunciaController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Index()
        {
            //pagenumber = 1;
            //busqueda = "";
            //sizepage = 10;
            //ViewData["size"] = sizePage;
            //ViewData["pagenumber"] = pageNumber;
            ViewData["search"] = busqueda;
            //sizepage = 10; pagenumber = 1; busqueda = "";
            var vista = await Listado();
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string search = "")
        {
            pagenumber = currentPage;
            busqueda = search;
            sizepage = sizePage;
            //ViewData["size"] = sizePage;
            ViewData["search"] = search;
            //ViewData["pagenumber"] = pageNumber;

            //var client = new RestClient(url);
            var vista = await Listado();

            return Json(Helper.RenderRazorViewToString(this, "PartialView/_ViewAllDenuncia", vista));
        }

        [NoDirectAccess]
        public async Task<IActionResult> AddOrEditDenuncia(int id = 0)
        {
            if (id == 0)
                return View(new Denuncia());
            else
            {
                //var modelo = await rest2.GetAsync(id, "api/Denuncia/GetDenuncia/" + id, HttpContext.Session.GetString("JWToken"));
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Denuncia/GetDenuncia/" + id, Method.GET);
                try
                {
                    var response = await client.ExecuteAsync<Denuncia>(request);
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
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditDenuncia(Denuncia model)
        {
            if (ModelState.IsValid)
            {
                //ViewData["itemsPerPage"] = sizepage;
                ViewData["search"] = busqueda;
                if (model.Id == 0)
                {
                    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/Denuncia/CreateDenuncia/", Method.POST).AddJsonBody(model);
                    try
                    {
                        //var resul= await rest2.PostAsync(model, "api/Denuncia/CreateDenuncia/", HttpContext.Session.GetString("JWToken"));
                        var response = await client.ExecuteAsync<Denuncia>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Denuncia creada.";
                        var vista = await Listado();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ViewAllDenuncia", vista) });
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
                        //var resul=await rest2.PutAsync(model, "api/Denuncia/UpdateDenuncia/" + model.Id);
                        var response = await client.ExecuteAsync<Denuncia>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Denuncia actualizada.";
                        var vista = await Listado();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ViewAllDenuncia", vista) });
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
            try
            {
                //var resul = await rest2.DeleteAsync(id, "api/Denuncia/DeleteDenuncia/");
                //TempData["alertsuccess"] = resul.ToString();
                var response = await client.ExecuteAsync<Denuncia>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "La denuncia fue eliminada de manera exitosa";
                //ViewData["itemsPerPage"] = sizepage;
                ViewData["search"] = busqueda;
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ViewAllDenuncia", vista) });
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
        public async Task<IEnumerable<Denuncia>> Listado()
        {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var requestGet = new RestRequest("api/Denuncia/GetAllDenuncias", Method.GET).AddParameter("Busqueda", busqueda).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", sizepage);
                var response = await client.ExecuteAsync<IEnumerable<Denuncia>>(requestGet);
                if (response.ResponseStatus.Equals(ResponseStatus.Error))
                    throw new Exception();
                var header = response.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
                var head = JObject.Parse(header.Value.ToString());
                ViewData["currentPage"] = head["currentPage"].ToString();
                ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
                ViewData["totalItems"] = head["totalItems"].ToString();
                ViewData["totalPages"] = head["totalPages"].ToString();
                var vista = response.Data;
                return vista;
        }
        public async Task<IActionResult> ExcelDenuncias()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Denuncia/GetAll", Method.GET);
            try
            {
                var response = await client.ExecuteAsync<IEnumerable<Denuncia>>(request);
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
                var content = ReportDenuncia.ExcelDenuncias(response.Data);
                return File(
                            content,
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                            "Denuncias.xlsx");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
