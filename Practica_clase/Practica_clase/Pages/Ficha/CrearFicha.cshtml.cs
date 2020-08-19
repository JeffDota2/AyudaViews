using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica_clase.Controllers;
using Practica_clase.Models;


namespace Practica_clase.Pages.Ficha
{
    public class CrearFichaModel : PageModel
    {
        [BindProperty]

        public CrearFicha CrearFicha { get; set; }
        public void OnGet()
        {


        }
    }
}