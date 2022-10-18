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
    [Area("AdministracionCuentas")]
    [Authorize(Roles = "SuperAdministrador, Administrador, Voluntario")]
    public class PerfilController : Controller
    {
        private static int id;
        private RestClient client;
        private static User _user;
        public PerfilController(IHttpContextAccessor httpContextAccessor)
        {
            client = new RestClient("https://localhost:44398/");
            id = int.Parse(httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
        [Route("Perfil/EditarPerfil")]
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
        [Route("Perfil/ActualizarEmail")]
        public async Task<IActionResult> ActualizarEmail()
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/GetUser/" + id, Method.GET);
            try
            {
                var response = await client.ExecuteAsync<User>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                _user = response.Data;
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
            ModelState.Remove("Password");
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/UpdateUser/", Method.PUT).AddJsonBody(user);
                try
                {
                    var response = await client.ExecuteAsync<User>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Datos de usuario actualizados.";
                    return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_EditarPerfil", response.Data) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_EditarPerfil", user) });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateEmail(int Id, string Email)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/UpdateEmail/", Method.PUT).AddJsonBody(JsonConvert.SerializeObject(new { Id, Email }));
                try
                {
                    var response = await client.ExecuteAsync<User>(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Email actualizado.";
                    return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ActualizarEmail", response.Data) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ActualizarEmail", _user) });
        }
        [Route("Perfil/ResetPassword")]
        public ActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPasswordUser(UpdateUserPassword dto)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/ResetPassword/" + id, Method.PUT).AddJsonBody(dto);
                try
                {
                    var response = await client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Contraseña actualizada.";
                    return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ResetPassword", dto) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "PartialView/_ResetPassword", dto) });
        }
    }
}
