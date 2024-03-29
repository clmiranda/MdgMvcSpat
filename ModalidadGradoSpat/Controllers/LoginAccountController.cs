﻿using DATA.DTOs;
using DATA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Controllers
{
    [AllowAnonymous]
    public class LoginAccountController : Controller
    {
        [Route("Login")]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ConfirmEmail()
        {
            TempData["alertsuccess"] = "Cuenta verificada correctamente.";
            return RedirectToAction("Login", "LoginAccount", new { area = "" });
        }
        [Route("ForgotPassword")]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        public ActionResult ResetPassword(string email, string token)
        {
            var model = new ResetPassword { Token = token, Email = email };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendDataLogin(UserForLogin datosUsuario)
        {
            if (ModelState.IsValid)
            {
                var request = new RestRequest("api/Auth/Login/", Method.POST).AddJsonBody(datosUsuario);
                try
                {
                    var response = await APIConnection.client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    dynamic valor = JsonConvert.DeserializeObject(response.Content);
                    User user = JsonConvert.DeserializeObject<User>(Convert.ToString(valor["user"]));
                    string token = valor["token"];
                    HttpContext.Session.SetString("JWToken", token);
                    if (user.Roles.Contains("SuperAdministrador"))
                        return Json(new { url = Url.Action("Dashboard", "Dashboard", new { area = "AdministracionCuentas" }) });
                    else if (user.Roles.Contains("Administrador"))
                        return Json(new { url = Url.Action("Lista", "Denuncia", new { area = "AdministracionMascotas" }) });
                    else if (user.Roles.Contains("Voluntario"))
                        return Json(new { url = Url.Action("Lista", "SeguimientoAsignado", new { area = "AdministracionSeguimientos" }) });
                    else
                        return Json(new { url = Url.Action("Inicio", "Adopciones", new { area = "" }) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = (string)msg["mensaje"];
                }
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "PartialViews/_Login", datosUsuario) });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendDataForgotPassword(ForgotPassword dto)
        {
            if (ModelState.IsValid)
            {
                var request = new RestRequest("api/Auth/forgotpassword/", Method.POST).AddJsonBody(dto);
                try
                {
                    var response = await APIConnection.client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Email enviado a su correo electrónico, debe ingresar al enlace enviado para reestablecer su Contraseña.";
                    return Json(new { url = Url.Action("Login", "LoginAccount", new { area = "" }) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "PartialViews/_ForgotPassword", dto) });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendDataResetPassword(ResetPassword valor)
        {
            if (ModelState.IsValid)
            {
                var request = new RestRequest("api/Auth/ResetPasswordExterno", Method.POST).AddJsonBody(valor);
                try
                {
                    var response = await APIConnection.client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    TempData["alertsuccess"] = "Contraseña restaurada correctamente.";
                    return Json(new { url = Url.Action("Login", "LoginAccount", new { area = "" }) });
                }
                catch (Exception ex)
                {
                    if (ex.Message == "")
                        throw new Exception();
                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = msg["mensaje"];
                }
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "PartialViews/_ResetPassword", valor) });
        }
        [Authorize(Roles = "SuperAdministrador, Administrador, Voluntario")]
        public IActionResult LogOut()
        {
            foreach (var cookie in HttpContext.Request.Cookies)
            {
                Response.Cookies.Delete(cookie.Key);
                Response.Cookies.Delete(cookie.ToString());
            }
            HttpContext.Session.Clear();
            return RedirectToAction("Inicio", "Adopciones", new { area = "" });
        }
    }
}