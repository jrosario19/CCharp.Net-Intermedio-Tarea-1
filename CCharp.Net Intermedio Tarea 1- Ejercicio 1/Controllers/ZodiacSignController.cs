using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCharp.Net_Intermedio_Tarea_1__Ejercicio_1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CCharp.Net_Intermedio_Tarea_1__Ejercicio_1.Controllers
{
    public class ZodiacSignController : Controller
    {
        [HttpGet]
        public IActionResult GetZodiacSign()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult GetZodiacSign(ZodiacSign zodiacSign)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("Details", zodiacSign);
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult Details(ZodiacSign zodiacSign)
        {
            //ZodiacSign zodiacSign1 = new ZodiacSign();
            switch (zodiacSign.Month)
            {
                case 1:
                    if (zodiacSign.Day < 21)
                    {
                        zodiacSign.Name = "Capricornio";
                    }
                    else
                    {
                        zodiacSign.Name = "Acuario";
                    }
                    break;
                case 2:
                    if (zodiacSign.Day < 19)
                    {
                        zodiacSign.Name = "Acuario";
                    }
                    else
                    {
                        zodiacSign.Name = "Pisis";
                    }
                    break;
                case 3:
                    if (zodiacSign.Day < 21)
                    {
                        zodiacSign.Name = "Pisis";
                    }
                    else
                    {
                        zodiacSign.Name = "Aries";
                    }
                    break;
                case 4:
                    if (zodiacSign.Day < 21)
                    {
                        zodiacSign.Name = "Aries";
                    }
                    else
                    {
                        zodiacSign.Name = "Tauro";
                    }
                    break;
                case 5:
                    if (zodiacSign.Day < 21)
                    {
                        zodiacSign.Name = "Tauro";
                    }
                    else
                    {
                        zodiacSign.Name = "Geminis";
                    }
                    break;
                case 6:
                    if (zodiacSign.Day < 25)
                    {
                        zodiacSign.Name = "Géminis";
                    }
                    else
                    {
                        zodiacSign.Name = "Cáncer";
                    }
                    break;
                case 7:
                    if (zodiacSign.Day < 23)
                    {
                        zodiacSign.Name = "Cáncer";
                    }
                    else
                    {
                        zodiacSign.Name = "Leo";
                    }
                    break;
                case 8:
                    if (zodiacSign.Day < 24)
                    {
                        zodiacSign.Name = "Leo";
                    }
                    else
                    {
                        zodiacSign.Name = "Virgo";
                    }
                    break;
                
                case 9:
                    if (zodiacSign.Day < 24)
                    {
                        zodiacSign.Name = "Virgo";
                    }
                    else
                    {
                        zodiacSign.Name = "Libra";
                    }
                    break;
                case 10:
                    if (zodiacSign.Day < 23)
                    {
                        zodiacSign.Name = "Libra";
                    }
                    else
                    {
                        zodiacSign.Name = "Escorpio";
                    }
                    break;
                case 11:
                    if (zodiacSign.Day < 23)
                    {
                        zodiacSign.Name = "Escorpio";
                    }
                    else
                    {
                        zodiacSign.Name = "Sagitario";
                    }
                    break;
                case 12:
                    if (zodiacSign.Day < 22)
                    {
                        zodiacSign.Name = "Sagitario";
                    }
                    else
                    {
                        zodiacSign.Name = "Capricornio";
                    }
                    break;
            }
            //var rangeDate =  string.Concat(zodiacSign.Day, zodiacSign.Month);
            //var rangeDateParsed = int.Parse(rangeDate);
            //if (rangeDateParsed >= 201 && rangeDateParsed <= 1802)
            //{
            //    zodiacSign.Name = "Acuario";
            //}
            //else
            //{
            //    if (rangeDateParsed >= 192 && rangeDateParsed <= 203)
            //    {
            //        zodiacSign.Name = "Pisis";
            //    }
            //    else
            //    {
            //        if (rangeDateParsed >= 213 && rangeDateParsed <= 204)
            //        {
            //            zodiacSign.Name = "Aries";
            //        }
            //        else
            //        {
            //            if (rangeDateParsed >= 214 && rangeDateParsed <= 205)
            //            {
            //                zodiacSign.Name = "Tauro";
            //            }
            //            else
            //            {
            //                if (rangeDateParsed >= 215 && rangeDateParsed <= 246)
            //                {
            //                    zodiacSign.Name = "Géminis";
            //                }
            //                else
            //                {
            //                    if (rangeDateParsed >= 256 && rangeDateParsed <= 226)
            //                    {
            //                        zodiacSign.Name = "Cáncer";
            //                    }
            //                    else
            //                    {
            //                        if (rangeDateParsed >= 237 && rangeDateParsed <= 238)
            //                        {
            //                            zodiacSign.Name = "Leo";
            //                        }
            //                        else
            //                        {
            //                            if (rangeDateParsed >= 248 && rangeDateParsed <= 239)
            //                            {
            //                                zodiacSign.Name = "Vrigo";
            //                            }
            //                            else
            //                            {
            //                                if (rangeDateParsed >= 249 && rangeDateParsed <= 2210)
            //                                {
            //                                    zodiacSign.Name = "Libra";
            //                                }
            //                                else
            //                                {
            //                                    if (rangeDateParsed >= 2310 && rangeDateParsed <= 2211)
            //                                    {
            //                                        zodiacSign.Name = "Escorpio";
            //                                    }
            //                                    else
            //                                    {
            //                                        if (rangeDateParsed >= 2311 && rangeDateParsed <= 2112)
            //                                        {
            //                                            zodiacSign.Name = "Sagitario";
            //                                        }
            //                                        else
            //                                        {
            //                                            if (rangeDateParsed >= 2212 && rangeDateParsed <= 191)
            //                                            {
            //                                                zodiacSign.Name = "Capricornio";
            //                                            }
            //                                        }
            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            return View(zodiacSign);
        }
    }
}
