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

namespace ModalidadGradoSpat.Areas.AdministracionMascotas.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class MascotaController : Controller
    {
        private static RestClient client;
        private static Mascota _mascota;
        private static IEnumerable<Mascota> _listaMascota;
        private static int? pagesize = 10; private static int? pagenumber = 1; private static string busqueda = ""; private static string filtrado = "Adopcion";
        public MascotaController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Index()
        {
            //var client = new RestClient(url);
            //client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            ViewData["search"] = busqueda;
            ViewData["filter"] = filtrado;
            //pagesize = 10; pagenumber = 1; busqueda = ""; filtrado = "Adopcion";
            var vista = await Listado();
            //var lista = await rest.GetAsync("api/Mascota/GetAllMascotas", HttpContext.Session.GetString("JWToken"));
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string filter = "Adopcion", string search = "")
        {
            pagesize = sizePage; pagenumber = currentPage; busqueda = search; filtrado = filter;
            //ViewData["currentPage"] = currentPage;
            //ViewData["itemsPerPage"] = sizePage;
            ViewData["filter"] = filter; ViewData["search"] = search;
            //var client = new RestClient(url);
            //client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_ListaMascotas", vista));
        }
        public async Task<IActionResult> MascotaView(int id)
        {
            //iddenuncia = id;
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Mascota/GetMascotaDenuncia/" + id, Method.GET);
            try
            {
                //var modelo = await restMascota.GetAsync(id, "api/Mascota/GetMascotaDenuncia/" + id, HttpContext.Session.GetString("JWToken"));
                //var client = new RestClient(url);
                var response = await client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);


                if (response.Content != null)
                {
                    _mascota = response.Data;
                    return View(_mascota);
                }
                return View(new Mascota { DenunciaId = id });
            }
            catch (Exception)
            {
                return View(null);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetFotoPrincipal(int id, int idfoto)
        {
            //var mascota= await restMascota.PostAsync("api/Fotos/Mascota/" + id + "/SetFotoPrincipalMascota/" + idfoto, HttpContext.Session.GetString("JWToken"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Fotos/Mascota/" + id + "/SetFotoPrincipalMascota/" + idfoto, Method.POST);
            try
            {
                var response = await client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                //var getMascota = await rest2.GetAsync(iddenuncia, "api/Denuncia/GetDenuncia/" + iddenuncia, HttpContext.Session.GetString("JWToken"));
                return Json(new { /*isValid=true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { /*isValid = false, */html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", _mascota) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFotoMascota(int idmascota, int idfoto)
        {
            //var resul = await rest3.DeleteAsync("api/Fotos/Mascota/" + idmascota + "/EliminarFotoMascota/" + idfoto);
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Fotos/Mascota/" + idmascota + "/EliminarFotoMascota/" + idfoto, Method.DELETE);
            try
            {
                var response = await client.ExecuteAsync<Mascota>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "La foto fue eliminada exitosamente.";
                return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", response.Data) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new {/* isValid = false, */html = Helper.RenderRazorViewToString(this, "PartialView/_Fotos", _mascota) });
            }
            //var denuncia = await rest2.GetAsync(iddenuncia, "api/Denuncia/GetDenuncia/" + iddenuncia, HttpContext.Session.GetString("JWToken"));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditMascota(int id, Mascota model)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/Mascota/CreateMascota/", Method.POST).AddJsonBody(model);
                    try
                    {
                        //var resul = await restMascota.PostAsync(model, "api/Mascota/CreateMascota/", HttpContext.Session.GetString("JWToken"));
                        var response = await client.ExecuteAsync<Mascota>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Registrado correctamente.";
                        return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_Mascota", response.Data)/*, html2 = Helper.RenderRazorViewToString(this, "Denuncia/PartialView/_Fotos", JsonConvert.DeserializeObject<Mascota>(response.Content))*/ });
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new { /*isValid = false, */html = Helper.RenderRazorViewToString(this, "PartialView/_Mascota", model) });
                    }
                    //var mascota = await restMascota.GetAsync(1, "api/Mascota/GetLastRegister/", HttpContext.Session.GetString("JWToken"));

                }
                else
                {
                    client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                    var request = new RestRequest("api/Mascota/UpdateMascota/", Method.PUT).AddJsonBody(model);
                    try
                    {
                        //var resul = await restMascota.PutAsync(model, "api/Mascota/UpdateMascota/");
                        var response = await client.ExecuteAsync<Mascota>(request);
                        if (!response.IsSuccessful)
                            throw new Exception(response.Content);
                        TempData["alertsuccess"] = "Modificado Correctamente.";
                        return Json(new {/* isValid = true,*/ html = Helper.RenderRazorViewToString(this, "PartialView/_Mascota", response.Data)/*, html2 = Helper.RenderRazorViewToString(this, "PartialViews/_Fotos", resul)*/ });
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "")
                            throw new Exception();
                        dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                        TempData["alerterror"] = msg["mensaje"];
                        return Json(new {/* isValid = false,*/ html = Helper.RenderRazorViewToString(this, "PartialView/_Mascota", model) });
                    }
                    //var mascota = await restMascota.GetAsync(model.Id, "api/Mascota/GetMascota/"+model.Id, HttpContext.Session.GetString("JWToken"));
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
                ViewData["filter"] = filtrado; ViewData["search"] = busqueda;
                var vista = await Listado();
                return Json(new { html= Helper.RenderRazorViewToString(this, "PartialView/_ListaMascotas", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ListaMascotas", _listaMascota) });
            }
        }

        //public async Task<IActionResult> GetAllMascotas() {
        //    var vista = await Listado();
        //    return View(vista);
        //}


        ///Metodo aun no implementado en la vista.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminar(int id)
        {
            //var resul = await rest.DeleteAsync(id, "api/Mascota/DeleteMascota/");
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Mascota/DeleteMascota/" + id, Method.DELETE);
            try
            {
                var response = await client.ExecuteAsync<string>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                //dynamic valor = JsonConvert.DeserializeObject(resul);
                //string mensaje = valor["mensaje"];
                //TempData["idcaso"] = valor["idcaso"];
                TempData["alertsuccess"] = "El fue eliminado de manera exitosa.";
                ViewData["filter"] = filtrado; ViewData["search"] = busqueda;
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaMascotas", vista) });
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
        public async Task<IEnumerable<Mascota>> Listado()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestGet = new RestRequest("api/Mascota/GetAllMascotas", Method.GET).AddParameter("Busqueda", busqueda).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
            var responseGet = await client.ExecuteAsync<IEnumerable<Mascota>>(requestGet);
            var header = responseGet.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
            var head = JObject.Parse(header.Value.ToString());
            ViewData["currentPage"] = head["currentPage"].ToString();
            ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
            ViewData["totalItems"] = head["totalItems"].ToString();
            ViewData["totalPages"] = head["totalPages"].ToString();
            var vista = responseGet.Data;
            _listaMascota = responseGet.Data;
            return vista;
        }
    }
}
