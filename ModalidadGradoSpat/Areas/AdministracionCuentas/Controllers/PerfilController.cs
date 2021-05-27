using DATA.DTOs;
using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Areas.AdministracionCuentas.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador, Voluntario")]
    public class PerfilController : Controller
    {
        private static int id;
        private static RestClient client;
        public PerfilController(IHttpContextAccessor httpContextAccessor)
        {
            client = new RestClient("https://localhost:44398/");
            id = int.Parse(httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
        public async Task<IActionResult> EditarPerfil()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/GetUser/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<User>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return View(response.Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUser(User user)
        {
            ModelState.Clear();
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/UpdateUser/", Method.PUT).AddJsonBody(user);
                try
                {
                    var response = await client.ExecuteAsync<User>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Datos actualizados.";
                    return Json(new { /*isValid = true, */html = Helper.RenderRazorViewToString(this, "PartialView/_EditarPerfil", response.Data) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { /*isValid = false*/html = Helper.RenderRazorViewToString(this, "PartialView/_EditarPerfil", user) });
        }
        public ActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPassword dto)
        {
            ModelState.Remove("Email");
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/ResetPassword/" + id, Method.PUT).AddParameter("Password", dto.Password);
                try
                {
                    var response = await client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Contraseña Actualizada.";
                    return Json(new { /*isValid=true, */html = Helper.RenderRazorViewToString(this, "PartialView/_ResetPassword", dto) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { /*isValid= false,*/ html = Helper.RenderRazorViewToString(this, "PartialView/_ResetPassword", dto) });
        }
    }
}
