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

namespace ModalidadGradoSpat.Areas.AdministracionAdopciones.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class AdopcionController : Controller
    {
        private static RestClient client;
        private static IEnumerable<ContratoAdopcion> _lista;
        private static int? pagesize = 10; private static int? pagenumber = 1; private static string filtrado = "Pendiente";
        private static ContratoAdopcion _contratoAdopcion = new ContratoAdopcion();
        public AdopcionController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        public async Task<IActionResult> Lista()
        {
            ViewData["filter"] = filtrado;
            var vista = await Listado();
            return View(vista);
        }
        public async Task<IActionResult> ReturnVista(int? sizePage = 10, int? currentPage = 1, string filter = "Pendiente")
        {
            pagesize = sizePage;
            pagenumber = currentPage;
            filtrado = filter;
            ViewData["filter"] = filter;
            var vista = await Listado();
            return Json(Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista));
        }
        [NoDirectAccess]
        public IActionResult AddContratoRechazo(int id)
        {
            return View(new ContratoRechazo { ContratoAdopcionId = id });
        }
        [NoDirectAccess]
        public IActionResult AddContratoCancelado(int id)
        {
            return View(new ContratoRechazo { ContratoAdopcionId = id });
        }
        public async Task<IActionResult> Detalle(int id)
        {
            //var resul = await rest.GetAsync(id, "api/ContratoAdopcion/DetailAdopcion/" + id, HttpContext.Session.GetString("JWToken"));
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ContratoAdopcion/DetailAdopcion/" + id, Method.GET);
                var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                _contratoAdopcion = response.Data;
                return View(_contratoAdopcion);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFecha(ContratoAdopcion contrato)
        {
            //var resul = await rest.PutAsync(contrato, "api/ContratoAdopcion/UpdateFecha");
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ContratoAdopcion/UpdateFecha", Method.PUT).AddJsonBody(contrato);
            try
            {
                var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Fecha actualizada exitosamente.";
                ViewData["filter"] = filtrado;
                //ViewData["itemsPerPage"] = pagesize;
                //ViewData["currentPage"] = pagenumber;
                //ViewData["search"] = busqueda;
                var vista = await Listado();
                return Json(new {html= Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
            catch (Exception ex)
            {
                TempData["alerterror"] = ex.Message.ToString();
                return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", _lista) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AprobarAdopcion(int id)
        {
            //var resul = await rest.PutAsync("api/ContratoAdopcion/" + id + "/AprobarAdopcion");
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ContratoAdopcion/" + id + "/AprobarAdopcion", Method.PUT);
            try
            {
                var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "El contrato se ha aprobado correctamente, se ha creado el seguimiento respectivo.";
                return Json(new { /*isValid = true,*/ html = Helper.RenderRazorViewToString(this, "PartialView/_AdministrarContrato", response.Data)/*, html2 = Helper.RenderRazorViewToString(this, "PartialView/_InformeContrato", response.Data)*/ });
            }
            catch (Exception ex)
            {
                TempData["alerterror"] = ex.Message.ToString();
                //var modelo = await rest.GetAsync(idcontrato, "api/ContratoAdopcion/DetailAdopcion/" + idcontrato, HttpContext.Session.GetString("JWToken"));
                return Json(new { /*isValid = false*/ html = Helper.RenderRazorViewToString(this, "PartialView/_AdministrarContrato", _contratoAdopcion)/*, html2 = Helper.RenderRazorViewToString(this, "_ViewContratoAprobacion", contratoAdopcion)*/ });
            }
            //var modelo = await rest.GetAsync(idcontrato, "api/ContratoAdopcion/DetailAdopcion/" + idcontrato, HttpContext.Session.GetString("JWToken"));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RechazarAdopcion(ContratoRechazo contrato)
        {
            if (ModelState.IsValid)
            {
                //var resul = await rest2.PostAsync(contrato, "api/ContratoAdopcion/RechazarAdopcion", HttpContext.Session.GetString("JWToken"));
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ContratoAdopcion/RechazarAdopcion", Method.PUT).AddJsonBody(contrato);
                try
                {
                    var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Contrato rechazado, se ha creado un informe de la razon del Rechazo";
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_AdministrarContrato", response.Data), html2 = Helper.RenderRazorViewToString(this, "PartialView/_InformeContrato", response.Data) });
                }
                catch (Exception ex)
                {
                    TempData["alerterror"] = ex.Message.ToString();
                    //var modelo = await rest.GetAsync(idcontrato, "api/ContratoAdopcion/DetailAdopcion/" + idcontrato, HttpContext.Session.GetString("JWToken"));
                    return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddContratoRechazo", contrato) });
                }
            }
            return Json(new { isValid = false/*, html = Helper.RenderRazorViewToString(this, "AddContratoRechazo", contrato)*/ });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelarAdopcion(ContratoRechazo contrato)
        {
            if (ModelState.IsValid)
            {
                //var resul = await rest2.PostAsync(contrato, "api/ContratoAdopcion/CancelarAdopcion", HttpContext.Session.GetString("JWToken"));
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/ContratoAdopcion/CancelarAdopcion", Method.PUT).AddJsonBody(contrato);
                try
                {
                    var response = await client.ExecuteAsync<ContratoAdopcion>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Contrato cancelado, se ha creado un informe de la razon de la Cancelacion.";
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_AdministrarContrato", response.Data), html2 = Helper.RenderRazorViewToString(this, "PartialView/_InformeContrato", response.Data) });
                }
                catch (Exception ex)
                {
                    TempData["alerterror"] = ex.ToString();
                    return Json(new {/* isValid = false,*/ html = Helper.RenderRazorViewToString(this, "AddContratoCancelado", contrato) });
                }
                //var modelo = await rest.GetAsync(idcontrato, "api/ContratoAdopcion/DetailAdopcion/" + idcontrato, HttpContext.Session.GetString("JWToken"));
            }
            return Json(new { isValid = false/*, html = Helper.RenderRazorViewToString(this, "AddContratoCancelado", contrato)*/ });
        }
        public async Task<IEnumerable<ContratoAdopcion>> Listado()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/ContratoAdopcion/GetAllAdopcionesPendientes", Method.GET).AddParameter("PageNumber", pagenumber).AddParameter("PageSize", pagesize).AddParameter("Filter", filtrado);
            var response = await client.ExecuteAsync<IEnumerable<ContratoAdopcion>>(request);
            var header = response.Headers.FirstOrDefault(x => x.Name.Equals("Pagination"));
            var head = JObject.Parse(header.Value.ToString());
            ViewData["currentPage"] = head["currentPage"].ToString();
            ViewData["itemsPerPage"] = head["itemsPerPage"].ToString();
            ViewData["totalItems"] = head["totalItems"].ToString();
            ViewData["totalPages"] = head["totalPages"].ToString();
            var vista = response.Data;
            _lista = vista;
            return vista;
        }
    }
}
