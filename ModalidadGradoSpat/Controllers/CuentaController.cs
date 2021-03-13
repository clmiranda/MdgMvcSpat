using DATA.DTOs;
using DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Controllers
{
    public class CuentaController : Controller
    {
        RestClient<UserForLogin> rest = new RestClient<UserForLogin>();
        RestClient<UserForRegister> rest2 = new RestClient<UserForRegister>();
        RestClient<ForgotPassword> rest3 = new RestClient<ForgotPassword>();
        RestClient<object> rest4 = new RestClient<object>();
        private static RestClient client;
        public CuentaController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        // GET: Cuenta
        public ActionResult Login(/*string alerta*/)
        {
            //TempData["alerta"] = alerta;
            return View();
        }
        public ActionResult Registro()
        {
            return View();
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
        public ActionResult ResetPassword(string email, string token)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendDataLogin(UserForLogin usu)
        {
            if (ModelState.IsValid)
            {
                //enviar objeto user y token para la session
                //var resul = await rest.Login(usu, "api/Auth/login");
                //client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Auth/login/", Method.POST).AddJsonBody(usu);
                try
                {
                    var response = await client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                    {
                        //if (response.ResponseStatus == ResponseStatus.Error)
                        //{
                        //    throw new Exception();
                        //}
                        //if (response.Content == "")
                        //    throw new Exception(response.ErrorException.InnerException.Message);
                        //else
                        throw new Exception(response.Content);
                    }
                    dynamic valor = JsonConvert.DeserializeObject(response.Content);
                    User user = JsonConvert.DeserializeObject<User>(Convert.ToString(valor["user"]));
                    string token = valor["token"];
                    HttpContext.Session.SetString("JWToken", token);
                    HttpContext.Session.SetString("SesionUser", JsonConvert.SerializeObject(user));
                    //return RedirectToAction("Index", "Inicio", new { area = "" });
                    return Json(new { url = Url.Action("Index", "Inicio") });
                }
                catch (Exception ex)
                {
                    //if (ex.Message != null)
                    //    TempData["alerterror"] = ex.Message;
                    //else
                    //{
                    if (ex.Message == "")
                        throw new Exception();

                    dynamic msg = JsonConvert.DeserializeObject(ex.Message);
                    TempData["alerterror"] = (string)msg["mensaje"];
                    //}
                }
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "PartialViews/_Login", usu) });
            //return RedirectToAction("Login", "Cuenta", new { area = "" });
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
                    var response = await client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    //var aux = await rest3.PostAsync(dto, "api/Auth/forgotpassword", HttpContext.Session.GetString("JWToken"));
                    TempData["alertsuccess"] = "Email enviado a su correo electrónico, debe ingresar al enlace enviado para reestablecer su Contraseña.";
                    return RedirectToAction("Login", "Cuenta", new { area = "" });
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
                var request = new RestRequest("api/Auth/ResetPasswordExterno", Method.POST).AddParameter("Email", valor.Email).AddParameter("Password", valor.Password);
                try
                {
                    var response = await client.ExecuteAsync(request);
                    if (!response.IsSuccessful)
                        throw new Exception(response.Content);
                    //var aux = await rest4.PostAsync(new { Email = valor.Email, Password = valor.Password }, "api/Auth/ResetPasswordExterno", HttpContext.Session.GetString("JWToken"));
                    TempData["alertsuccess"] = "Contraseña restaurada de manera correcta.";
                    return RedirectToAction("Login", "Cuenta", new { area = "" });
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

        // GET: Cuenta/Details/5
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Cuenta", new { area = "" });
        }
    }
}
