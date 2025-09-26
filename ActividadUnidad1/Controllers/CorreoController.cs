using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CorreoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string correo)
        {
            if (!string.IsNullOrEmpty(correo) && correo.Contains("@"))
            {
                string usuario = correo.Split('@')[0];
                ViewBag.Resultado = $"El usuario es: {usuario}";
            }
            else
            {
                ViewBag.Resultado = "Correo no válido.";
            }

            return View();
        }
    }
}
