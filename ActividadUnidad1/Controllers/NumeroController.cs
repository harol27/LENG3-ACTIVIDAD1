using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(double numero)
        {
            string resultado = numero > 0 ? $"{numero} es POSITIVO."
                              : numero < 0 ? $"{numero} es NEGATIVO."
                              : "El número es CERO.";

            ViewBag.Resultado = resultado;
            return View();
        }

        [HttpGet]
        public IActionResult Tabla() => View();

        [HttpPost]
        public IActionResult Tabla(int numero)
        {
            var resultados = new List<string>();
            for (int i = 1; i <= 10; i++)
                resultados.Add($"{numero} x {i} = {numero * i}");

            ViewBag.Numero = numero;
            ViewBag.Tabla = resultados;
            return View();
        }
    }
}
