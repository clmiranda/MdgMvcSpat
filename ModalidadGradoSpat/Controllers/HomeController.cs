﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModalidadGradoSpat.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static ModalidadGradoSpat.Helper;

namespace ModalidadGradoSpat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[NoDirectAccess]
        [Route("Home/Error/{StatusCode}")]
        public IActionResult StatusCodeHandle(int statusCode)
        {
            switch (statusCode)
            {
                case 401:
                    ViewBag.Error = "401";
                    break;
                case 403:
                    ViewBag.Error = "403";
                    break;
                case 404:
                    ViewBag.Error = "404";
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}
