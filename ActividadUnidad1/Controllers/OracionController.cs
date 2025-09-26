using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class OracionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string frase)
        {
            int contador = 0;
            if (!string.IsNullOrEmpty(frase))
            {
                string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";
                foreach (char c in frase)
                    if (vocales.Contains(c))
                        contador++;
            }

            ViewBag.Resultado = $"La frase contiene {contador} vocales.";
            return View();
        }
    }
}
