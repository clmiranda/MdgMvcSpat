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

namespace ModalidadGradoSpat.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador, Voluntario")]
    public class AdopcionesController : Controller
    {
        private static RestClient client;
        private static int? pagesize = 10; private static int? pagenumber = 1; /*private static string busqueda = "";*/ private static string filtrado = "Adopcion";
        public AdopcionesController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Lista()
        {
            ViewData["filter"] = "Adopcion";
            var vista = await Listado();
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1/*, string search = ""*/, string filter = "Adopcion")
        {
            pagesize = sizePage; pagenumber = currentPage; /*busqueda = search;*/ filtrado = filter;
            ViewData["filter"] = filter; /*ViewData["search"] = search;*/
            //ViewData["page"] = pageNumber;
            //ViewData["size"] = sizePage;
            //ViewData["filter"] = filter;
            //ViewData["search"] = search;
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        public async Task<IActionResult> InformacionMascota(int id)
        {
            //var resul = await rest2.GetAsync(id, "api/ContratoAdopcion/GetContratoByIdMascota/" + id, HttpContext.Session.GetString("JWToken"));
            //if (resul != null)
            //    return RedirectToAction("StatusCodeHandle", "Error", new { statusCode = 404 });

            //var mascota = await rest.GetAsync(id, "api/Mascota/GetMascota/" + id, HttpContext.Session.GetString("JWToken"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Mascota/GetMascota/" + id, Method.GET);
                var response = await client.ExecuteAsync<Mascota>(request);
                //if (mascota==null)
                //    return RedirectToAction("StatusCodeHandle", "Error", new { statusCode = 404 });
                return View(JsonConvert.DeserializeObject<ContratoAdopcion>(response.Content));
        }
        public IActionResult TerminosDeAdopcion()
        {
            return View();
        }
        public async Task<IActionResult> ContratoAdopcion(int id)
        {
            //if (id!=0)
            //{
            //var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SesionUser"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ContratoAdopcion/GetContratoByIdMascota/" + id, Method.GET);
            //try
            //{
                //var resul = await rest2.GetAsync(id, "api/ContratoAdopcion/GetContratoByIdMascota/" + id, HttpContext.Session.GetString("JWToken"));
                var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                //else
                //{
                    if (response.Data != null)
                        return View(response.Data);
                    else
                        return View(new ContratoAdopcion { MascotaId = id });
                //}
            //}
            //catch (Exception)
            //{
            //    return View(null);
            //}
        }
        //public IActionResult ContratoAdopcionFotos() {
        //    Foto foto = new Foto { 
        //    ContratoAdopcionId=idContrato
        //    };
        //    return View(foto);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostContrato(ContratoAdopcion modelo)
        {
            if (ModelState.IsValid)
            {
                //var res = await rest2.PostAsync(modelo, "api/ContratoAdopcion/GenerarContrato/", HttpContext.Session.GetString("JWToken"));
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ContratoAdopcion/GenerarContrato", Method.POST).AddJsonBody(modelo);
                try
                {
                    var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    //idContrato = int.Parse(res);
                    //return RedirectToAction("Index", "Inicio");
                    TempData["alertsuccess"] = "Contrato enviado, nos comunicaremos con usted en caso de cumplir los requisitos.";
                    return Json(new { isValid=true, html = Helper.RenderRazorViewToString(this, "Adopciones/PartialView/_ContratoAdopcion", response.Data) });
                }
                catch (Exception ex)
                {
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { isValid = false/*, html = Helper.RenderRazorViewToString(this, "Adopciones/PartialView/_ContratoAdopcion", modelo)*/ });
        }


        public async Task<IEnumerable<Mascota>> Listado()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var requestGet = new RestRequest("api/Mascota/GetAllMascotaAdopcion", Method.GET)/*.AddParameter("Busqueda", busqueda)*/.AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
            IRestResponse responseGet = await client.ExecuteAsync(requestGet);
            var header = responseGet.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
            var head = JObject.Parse(header.Value.ToString());
            ViewData["currentPage"] = head["currentPage"].ToString();
            ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
            ViewData["totalItems"] = head["totalItems"].ToString();
            ViewData["totalPages"] = head["totalPages"].ToString();
            var vista = JsonConvert.DeserializeObject<IEnumerable<Mascota>>(responseGet.Content);
            return vista;
        }
    }
}
