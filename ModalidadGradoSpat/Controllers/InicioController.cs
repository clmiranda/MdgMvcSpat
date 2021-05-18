using DATA.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Controllers
{
    public class InicioController : Controller
    {
        private static RestClient client;
        public InicioController()
        {
            client = new RestClient("https://localhost:44398/");
        }
        //[Authorize(Roles = "SuperAdministrador, Administrador, Voluntario")]
        //public ActionResult Index()
        //{
        //    if (HttpContext.Session.GetString("JWToken") == "" || HttpContext.Session.GetString("JWToken") == null)
        //        return RedirectToAction("Login", "Cuenta");

        //    ViewData["tokenjwt"] = HttpContext.Session.GetString("JWToken");
        //    return View();
        //}
        [Authorize(Roles = "SuperAdministrador, Administrador")]
        public async Task<IActionResult> Dashboard() {
            if (HttpContext.Session.GetString("JWToken") == "" || HttpContext.Session.GetString("JWToken") == null)
                return RedirectToAction("Login", "Cuenta");

            client.Authenticator = new JwtAuthenticator(HttpContext.Session.GetString("JWToken"));
            var request = new RestRequest("api/Graficas/GetDataForDashboard/", Method.GET);
            var response = await client.ExecuteAsync<DataForDashboardDto>(request);
            return View(response.Data);
        }
    }
}
