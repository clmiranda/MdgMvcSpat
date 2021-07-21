using Microsoft.AspNetCore.Mvc;

namespace ModalidadGradoSpat.Controllers
{
    public class ErrorsHandleController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult StatusCodeHandle(int statusCode = 500)
        {
            switch (statusCode)
            {
                case 401:
                    ViewBag.Error = 401;
                    break;
                case 403:
                    ViewBag.Error = 403;
                    break;
                case 404:
                    ViewBag.Error = 404;
                    break;
                case 405:
                    ViewBag.Error = 405;
                    break;
                case 500:
                    ViewBag.Error = 500;
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}
