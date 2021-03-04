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
        //public async Task<IActionResult> Mascota(int id)
        //{
        //    //iddenuncia = id;
        //    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
        //    var request = new RestRequest("api/Mascota/GetMascotaDenuncia/" + id, Method.GET);
        //    try
        //    {
        //        //var modelo = await restMascota.GetAsync(id, "api/Mascota/GetMascotaDenuncia/" + id, HttpContext.Session.GetString("JWToken"));
        //        //var client = new RestClient(url);
        //        var response = await client.ExecuteAsync<Mascota>(request);
        //        if (!response.IsSuccessful)
        //            throw new Exception(response.Content);


        //        if (response.Content != null)
        //        {
        //            mascota = response.Data;
        //            return View(mascota);
        //        }
        //        return View(new Mascota { DenunciaId = id });
        //    }
        //    catch (Exception)
        //    {
        //        return View(null);
        //    }
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> EstablecerFotoPrincipal(int id, int idfoto)
        //{
        //    //var mascota= await restMascota.PostAsync("api/Fotos/Mascota/" + id + "/SetFotoPrincipalMascota/" + idfoto, HttpContext.Session.GetString("JWToken"));
        //    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
        //    var request = new RestRequest("api/Fotos/Mascota/" + id + "/SetFotoPrincipalMascota/" + idfoto, Method.POST);
        //    try
        //    {
        //        var response = await client.ExecuteAsync<Mascota>(request);
        //        if (!response.IsSuccessful)
        //            throw new Exception(response.Content);
        //        //var getMascota = await rest2.GetAsync(iddenuncia, "api/Denuncia/GetDenuncia/" + iddenuncia, HttpContext.Session.GetString("JWToken"));
        //        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", response.Content) });
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["alerterror"] = ex.Message.ToString();
        //        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", mascota) });
        //    }
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> EliminarFotoMascota(int idmascota, int idfoto)
        //{
        //    //var resul = await rest3.DeleteAsync("api/Fotos/Mascota/" + idmascota + "/EliminarFotoMascota/" + idfoto);
        //    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
        //    var request = new RestRequest("api/Fotos/Mascota/" + idmascota + "/EliminarFotoMascota/" + idfoto, Method.DELETE);
        //    try
        //    {
        //        var response = await client.ExecuteAsync<Mascota>(request);
        //        if (!response.IsSuccessful)
        //            throw new Exception(response.Content);
        //        TempData["alertsuccess"] = "La foto fue eliminada exitosamente.";
        //        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", response.Content) });
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["alerterror"] = ex.Message.ToString();
        //        return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", mascota) });
        //    }
        //    //var denuncia = await rest2.GetAsync(iddenuncia, "api/Denuncia/GetDenuncia/" + iddenuncia, HttpContext.Session.GetString("JWToken"));
        //}

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
                var response = await client.GetAsync<Denuncia>(request);
                return View(response);
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
                        TempData["alertsuccess"] = "Denuncia creada exitosamente.";
                        var vista = await Listado();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ViewAllDenuncia", vista) });
                    }
                    catch (Exception ex)
                    {
                        TempData["alerterror"] = ex.Message.ToString();
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
                        TempData["alertsuccess"] = "Denuncia modificada exitosamente.";
                        var vista = await Listado();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ViewAllDenuncia", vista) });
                    }
                    catch (Exception ex)
                    {
                        TempData["alerterror"] = ex.Message.ToString();
                        return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEditDenuncia", model) });
                    }
                }
            }
            return Json(new { isValid = false});
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
                TempData["alerterror"] = ex.Message.ToString();
                return Json(new { isValid = false });
            }
        }
        public async Task<IEnumerable<Denuncia>> Listado()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestGet = new RestRequest("api/Denuncia/GetAllDenuncias", Method.GET).AddParameter("Busqueda", busqueda).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", sizepage);
            var responseGet = await client.ExecuteAsync<IEnumerable<Denuncia>>(requestGet);
            var header = responseGet.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
            var head = JObject.Parse(header.Value.ToString());
            ViewData["currentPage"] = head["currentPage"].ToString();
            ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
            ViewData["totalItems"] = head["totalItems"].ToString();
            ViewData["totalPages"] = head["totalPages"].ToString();
            var vista = responseGet.Data;
            return vista;
        }
    }
}
