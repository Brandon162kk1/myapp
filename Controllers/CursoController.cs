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

    public class CursoController : Controller
    {
        private readonly ILogger<CursoController> _logger;

        public CursoController(ILogger<CursoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar(Curso objCurso)
        {
        int v1,v2,v3,cred=3 , preCred=100,monto;
        double igv,mt;
        v1=Convert.ToInt32(objCurso.Materia1);
        v2=Convert.ToInt32(objCurso.Materia2);
        v3=Convert.ToInt32(objCurso.Materia3);
        if(v1==1 && v2==1 && v3==1){
            monto=cred*preCred*3;
            igv=0.18*monto;
            mt=monto+igv;
            ViewData["Message1"] ="Total Cursos: " + monto;
            ViewData["Message2"] ="IGV: " + igv;
            ViewData["Message3"] ="Total a Pagar: " + mt;
            return View("Index"); 
        }else if(v1==1 && v2==1){
            monto=cred*preCred*2;
            igv=0.18*monto;
            mt=monto+igv;
            ViewData["Message1"] ="Total Cursos: " + monto;
            ViewData["Message2"] ="IGV: " + igv;
            ViewData["Message3"] ="Total a Pagar: " + mt;
            return View("Index");  
        }else if(v1==1 && v3==1){
            monto=cred*preCred*2;
            igv=0.18*monto;
            mt=monto+igv;
            ViewData["Message1"] ="Total Cursos: " + monto;
            ViewData["Message2"] ="IGV: " + igv;
            ViewData["Message3"] ="Total a Pagar: " + mt;
            return View("Index");  
        }else if(v2==1 && v3==1){
            monto=cred*preCred*2;
            igv=0.18*monto;
            mt=monto+igv;
            ViewData["Message1"] ="Total Cursos: " + monto;
            ViewData["Message2"] ="IGV: " + igv;
            ViewData["Message3"] ="Total a Pagar: " + mt;
            return View("Index");  
        }else{
            monto=cred*preCred;
            igv=0.18*monto;
            mt=monto+igv;
            ViewData["Message1"] ="Total Cursos: " + monto;
            ViewData["Message2"] ="IGV: " + igv;
            ViewData["Message3"] ="Total a Pagar: " + mt;
            return View("Index");  
        } 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}