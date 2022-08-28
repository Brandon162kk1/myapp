using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace myapp.Models
{
    public class Formulario
    {
        
        [Display(Name = "Nombre de pila", Prompt = "Ingrese el nombre")]
        public string? Nombre {get; set; }

        [Display(Name = "Apellido", Prompt = "Introduzca el apellido")]
        public string? Apellido {get; set; }

        [Display(Name = "Titulo Profesional",Prompt = "Ingrese el titulo de su trabajo")]
        public string? Titulo {get; set; }

        [Display(Name = "El mas alto nivel de educación")]
        public string? Nivel {get; set;}

        [Display(Name = "Sexo")]
        public string? Sexo {get; set;}

        [Display(Name = "Años de Experiencia")]
        public string? Año {get; set;}
        
        [Display(Name = "Fecha")]
        public string? Fecha {get; set;}
    }
}