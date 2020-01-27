using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCharp.Net_Intermedio_Tarea_1__Ejercicio_1.Models
{
    public class ZodiacSign
    {
        [Required]
        [Display(Name = "Dia")]
        [Range(1,31, ErrorMessage ="Dia debe estar entre 1 y 31"])
        public int Day { get; set; }
        [Required]
        [Display(Name = "Mes")]
        [Range(1, 12, ErrorMessage = "Dia debe estar entre 1 y 12"])
        public int Month { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
    }
}
