using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_clase.Models
{
    public class CrearFicha
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name =  "Su Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name =  "Su Apellido")]

        public string Apellido { get; set; }
        [Required]
        [Display(Name =  "Su Cedula")]

        public string Cedula { get; set; }
        [Required]
        [Display(Name =  "Su Direccion")]

        public string Direccion { get; set; }
        [Required]
        [Display(Name =  "Su Edad")]

        public int Edad { get; set; }
    }
    
}
