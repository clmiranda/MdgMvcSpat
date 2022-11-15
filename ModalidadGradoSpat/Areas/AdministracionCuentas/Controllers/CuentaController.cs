using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModalidadGradoSpat.Reports;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Areas.AdministracionCuentas.Controllers
{
    [Area("AdministracionCuentas")]
    [Authorize(Roles = "SuperAdministrador")]
    public class CuentaController : Controller
    {
        private static int idUser;
        [Route("Cuenta/ListaUsuarios")]
        public async Task<ActionResult> ListaUsuarios()
        {
            var vista = await Listado();
            return View(vista);
        }
        [NoDirectAccess]
        public ActionResult CreateUsuario()
        {
            var user = new User
            {
                Persona = new Persona()
            };
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUsuario(User usuario, Persona persona)
        {
            if (ModelState.IsValid)
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                usuario.Persona = persona;
                var request = new RestRequest("api/User/CreateUser/", Method.POST).AddJsonBody(usuario);
                try
                {
                    var response = await APIConnection.client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Usuario creado, email de confirmacion de la cuenta enviado al correo electronico.";
                    var lista = JsonConvert.DeserializeObject<IEnumerable<User>>(response.Content);
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaUsuarios", lista) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "CreateUsuario", usuario) });
        }
        [NoDirectAccess]
        public ActionResult AsignarRoles(int id, string[] roles)
        {
            idUser = id;
            return View(roles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AsignarRoles(string[] RolesUser)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/AsignarRoles/" + idUser, Method.POST).AddJsonBody(RolesUser);
            try
            {
                var response = await APIConnection.client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Roles actualizados.";
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaUsuarios", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AsignarRoles", RolesUser) });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CambiarEstado(int idUser)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/CambiarEstado/" + idUser, Method.PUT);
            try
            {
                var response = await APIConnection.client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Estado modificado.";
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaUsuarios", vista) });
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteUsuario(int idUser)
        {
            APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/DeleteUser/" + idUser, Method.DELETE);
            try
            {
                var response = await APIConnection.client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Usuario eliminado.";
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaUsuarios", vista) });
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
        public async Task<IEnumerable<User>> Listado()
        {
            try
            {
                APIConnection.client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/GetAllUsers/", Method.GET);
                var response = await APIConnection.client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                var vista = JsonConvert.DeserializeObject<IEnumerable<User>>(response.Content);
                return vista;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task<IActionResult> ExcelUsuario()
        {
            try
            {
                var lista = await Listado();
                var content = ReportUser.ExcelUsers(lista);
                return File(
                    content,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "Usuarios.xlsx");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}