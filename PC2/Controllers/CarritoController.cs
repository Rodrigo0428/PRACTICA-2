using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC2.Models;

namespace PC2.Controllers
{
    
    public class CarritoController : Controller
    {
        private readonly ILogger<CarritoController> _logger;

        public CarritoController(ILogger<CarritoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            var producto  = Util.SessionExtension.Get<Producto>(HttpContext.Session,"Mi Ultimo Producto");
            return View("UltimoProducto", producto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}