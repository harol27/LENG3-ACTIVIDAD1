using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        [HttpGet]
        public IActionResult Convertir() => View();

        [HttpPost]
        public IActionResult Convertir(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            ViewBag.Fahrenheit = fahrenheit;
            ViewBag.Celsius = celsius;
            return View();
        }
    }
}

