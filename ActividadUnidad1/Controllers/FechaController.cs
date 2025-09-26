using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ActividadUnidad1.Controllers
{
    public class FechaController : Controller
    {
        [HttpGet]
        public IActionResult Index ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DateTime fecha)
        {
            string diaSemana = fecha.ToString("dddd", new CultureInfo("es-ES"));
            ViewBag.Resultado = $"La fecha {fecha.ToShortDateString()} corresponde a: {diaSemana}";
            return View();
        }
    }
}
