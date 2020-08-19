using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_clase.Models
{
    public class Imc
    {
        [Required]
        [Display(Name = "Su Peso")]
        public decimal Peso { get; set; }
        [Required]
        [Display(Name = "Su Altura")]
        public decimal Altura { get; set; }
    }
}