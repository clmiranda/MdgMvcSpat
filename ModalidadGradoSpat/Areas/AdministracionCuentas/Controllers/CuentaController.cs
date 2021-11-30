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
        private static RestClient client;
        private static int idUser;
        public CuentaController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [Route("Cuenta/ListaUsuarios")]
        public async Task<ActionResult> ListaUsuarios()
        {
            var vista = await Listado();
            return View(vista);
        }
        [NoDirectAccess]
        public ActionResult CreateUsuario()
        {
            return View(new User());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUsuario(User usuario)
        {
            if (ModelState.IsValid)
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/CreateUser/", Method.POST).AddJsonBody(usuario);
                try
                {
                    var response = await client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Un Email de confirmacion de la cuenta ha sido enviado al Correo Electronico.";
                    var vista = await Listado();
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_ListaUsuarios", vista) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { isValid = false });
        }
        [NoDirectAccess]
        public ActionResult AsignarRoles(int id, string[] roles)
        {
            idUser = id;
            return View(roles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AsignarRoles(string[] rolesUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/AsignarRoles/" + idUser, Method.POST).AddJsonBody(rolesUser);
            try
            {
                var response = await client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Roles asignados.";
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
            }
            catch (Exception ex)
            {
                if (ex.Message == "")
                    throw new Exception();
                dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                TempData["alerterror"] = msg["mensaje"];
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AsignarRoles", rolesUser) });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CambiarEstado(int idUser)
        {
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/CambiarEstado/" + idUser, Method.PUT);
            try
            {
                var response = await client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Estado modificado.";
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
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
            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/User/DeleteUser/" + idUser, Method.DELETE);
            try
            {
                var response = await client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                    throw new Exception(response.Content);
                TempData["alertsuccess"] = "Usuario eliminado.";
                var vista = await Listado();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "PartialView/_Lista", vista) });
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
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/User/GetAllUsers/", Method.GET);
                var response = await client.ExecuteAsync(request);
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