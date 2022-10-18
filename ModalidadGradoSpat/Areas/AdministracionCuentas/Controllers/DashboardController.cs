using DATA.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Areas.AdministracionCuentas.Controllers
{
    [Area("AdministracionCuentas")]
    [Authorize(Roles = "SuperAdministrador")]
    public class DashboardController : Controller
    {
        private RestClient client;
        private string filtro = "3 meses";
        public DashboardController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        [HttpGet]
        [Route("Dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            if (HttpContext.Session.GetString("JWToken") == "" || HttpContext.Session.GetString("JWToken") == null)
                return RedirectToAction("Login", "Cuenta");
            ViewData["filter"] = filtro;
            var vista = await Datos();
            return View(vista);
        }
        public async Task<DataForDashboardDto> Datos()
        {
            try
            {
                client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
                var request = new RestRequest("api/Graficas/GetDataForDashboard/", Method.GET);
                var response = await client.ExecuteAsync<DataForDashboardDto>(request);
                if (!response.IsSuccessful)
                    throw new Exception();
                return response.Data;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
