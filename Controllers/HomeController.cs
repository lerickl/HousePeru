using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HousesPeru.Models;
using HousesPeru.Servicios;

namespace HousesPeru.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly IInmuebleService inmuebleService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IInmuebleService _inmuebleService)
        {
            _logger = logger;
            this.inmuebleService = _inmuebleService;
        }
   
        public IActionResult Index()
        {
            var Inmuebles = inmuebleService.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
