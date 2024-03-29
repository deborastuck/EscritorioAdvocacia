﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace EscritorioAdvocacia.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Sistema para Escritório de Advocacia.";

            return View();
        }

        public IActionResult Contact() {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new EscritorioAdvocacia.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
