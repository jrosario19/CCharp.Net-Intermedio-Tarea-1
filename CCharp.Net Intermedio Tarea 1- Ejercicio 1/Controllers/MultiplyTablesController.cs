using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCharp.Net_Intermedio_Tarea_1__Ejercicio_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCharp.Net_Intermedio_Tarea_1.Controllers
{
    public class MultiplyTablesController : Controller
    {
        public IActionResult GetMultiplyTable()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetMultiplyTable(MultiplyTable multiplyTable)
        {

            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Details", multiplyTable);
            }

            return View();

        }
        

        public IActionResult Details(MultiplyTable multiplyTable)
        {
            List<MultiplyTable> multiplyTables = new List<MultiplyTable>() { new MultiplyTable{
                Multiplyer=1,
                Multiplying=multiplyTable.Multiplying,
                Result= 1*multiplyTable.Multiplying

            },
            new MultiplyTable{
                Multiplyer=2,
                Multiplying=multiplyTable.Multiplying,
                Result = 2 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=3,
                Multiplying=multiplyTable.Multiplying,
                Result = 3 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=4,
                Multiplying=multiplyTable.Multiplying,
                Result = 4 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=5,
                Multiplying=multiplyTable.Multiplying,
                Result = 5 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=6,
                Multiplying=multiplyTable.Multiplying,
                Result = 6 * multiplyTable.Multiplying

            },
            new MultiplyTable{
                Multiplyer=7,
                Multiplying=multiplyTable.Multiplying,
                Result = 7 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=8,
                Multiplying=multiplyTable.Multiplying,
                Result = 8 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=9,
                Multiplying=multiplyTable.Multiplying,
                Result = 9 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=10,
                Multiplying=multiplyTable.Multiplying,
                Result = 10 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=11,
                Multiplying=multiplyTable.Multiplying,
                Result = 11 * multiplyTable.Multiplying
            },
            new MultiplyTable{
                Multiplyer=12,
                Multiplying=multiplyTable.Multiplying,
                Result = 12 * multiplyTable.Multiplying
            } };
            return View(multiplyTables);
        }
    }
}
    