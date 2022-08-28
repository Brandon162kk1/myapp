using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myapp.Models;

namespace myapp.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar(Producto objProducto)
        {
            double igv,monto,mT;

            monto=objProducto.Precio * objProducto.Cantidad;
            igv=18*monto/100;
            mT=monto+igv;//1.18*monto--otra forma de hallar el mT
            
            ViewData["Message"] =objProducto.Nombre + " fue registrado con exito, con monto total de S/"+ mT +" incluido IGV: "+igv;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}