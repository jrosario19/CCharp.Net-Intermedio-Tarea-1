using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCharp.Net_Intermedio_Tarea_1__Ejercicio_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCharp.Net_Intermedio_Tarea_1.Controllers
{
    public class QuadraticEquationController : Controller
    {
        public IActionResult GetQuadraticEquation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetQuadraticEquation(QuadraticEquation quadraticEquation)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Details", quadraticEquation);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Details(QuadraticEquation quadraticEquation)
        {
            var a = quadraticEquation.AValue;
            var b = quadraticEquation.BValue;
            var c = quadraticEquation.CValue;
            var discriminator = quadraticEquation.Discriminator = Math.Pow(b, 2) - 4 * a * c;
            if (discriminator == 0)
            {
                quadraticEquation.Message = "La Ecuación tiene una única solución";
                quadraticEquation.Solution1 = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                quadraticEquation.Solution2 = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            }
            else
            {
                if (discriminator < 0)
                {
                    quadraticEquation.Message = "La ecuación cuadratica no tiene soluciones (reales)";
                    quadraticEquation.Solution1 = 0;
                    quadraticEquation.Solution1 = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                    quadraticEquation.Solution2 = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                }
                else
                {
                    if (discriminator>0)
                    {
                        quadraticEquation.Message = "La Ecuación tiene dos soluciones";
                        quadraticEquation.Solution1 = (((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
                        quadraticEquation.Solution2 = (((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
                    }
                }
            }
            return View(quadraticEquation);
        }
    }
}