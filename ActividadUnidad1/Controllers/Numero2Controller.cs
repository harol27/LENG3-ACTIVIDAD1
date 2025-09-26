using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActividadUnidad1.Controllers
{
    public class Numero2Controller : Controller
    {
        [HttpGet]
        public IActionResult Tabla()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Tabla(int numero)
        {
            var resultados = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                resultados.Add($"{numero} x {i} = {numero * i}");
            }

            ViewBag.Numero = numero;
            ViewBag.Tabla = resultados;

            return View();
        }
    }
}
 