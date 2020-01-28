using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCharp.Net_Intermedio_Tarea_1__Ejercicio_1.Models
{
    public class MultiplyTable
    {
        [Required(ErrorMessage ="Multiplicando es un campo obligatorio")]
        [Display(Name = "Multiplicando")]
        public int Multiplying { get; set; }
        public int Multiplyer { get; set; }
        public int Result { get; set; }
    }
}
