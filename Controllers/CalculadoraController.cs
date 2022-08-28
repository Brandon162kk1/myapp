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
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(Calculadora objCalculadora)
        {

            double resultado;
            switch(objCalculadora.Operando){
                case "+": resultado=objCalculadora.Operador1+objCalculadora.Operador2;break;
                case "-": resultado=objCalculadora.Operador1-objCalculadora.Operador2;break;
                case "*": resultado=objCalculadora.Operador1*objCalculadora.Operador2;break;
                default: resultado=objCalculadora.Operador1/objCalculadora.Operador2;break;
            }
            
            ViewData["Message"] = "El resultado es: "+ resultado;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}