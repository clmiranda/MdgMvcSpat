using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador, Voluntario")]
    public class InicioController : Controller
    {
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("JWToken") == "" || HttpContext.Session.GetString("JWToken") == null)
                return RedirectToAction("Login", "Cuenta");

            ViewData["tokenjwt"] = HttpContext.Session.GetString("JWToken");
            return View();
        }
    }
}
