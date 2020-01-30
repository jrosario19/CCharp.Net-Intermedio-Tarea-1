using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCharp.Net_Intermedio_Tarea_1__Ejercicio_1.Models
{
    public class QuadraticEquation
    {
        [Display(Name = "Valor de a")]
        [Range(short.MinValue, short.MaxValue, ErrorMessage = "El valor debe estar entre -32,768 y 32,767")]
        [Required(ErrorMessage = "Campo requerido")]
        public int AValue { get; set; }
        [Display(Name = "Valor de b")]
        [Range(short.MinValue, short.MaxValue, ErrorMessage = "El valor debe estar entre -32,768 y 32,767")]
        [Required(ErrorMessage = "Campo requerido")]
        public double BValue { get; set; }
        [Display(Name = "Valor de c")]
        [Range(short.MinValue, short.MaxValue, ErrorMessage = "El valor debe estar entre -32,768 y 32,767")]
        [Required(ErrorMessage = "Campo requerido")]
        public int CValue { get; set; }
        public double Discriminator { get; set; }
        [Display(Name = "Solución 1")]
        [DataType(DataType.Currency)]
        public double Solution1 { get; set; }
        [Display(Name = "Solución 2")]
        public double Solution2 { get; set; }
        public string Message { get; set; }
    }
}
