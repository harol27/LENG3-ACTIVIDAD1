using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PrimoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int numero)
        {
            bool esPrimo = true;

            if (numero <= 1)
                esPrimo = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            ViewBag.Resultado = esPrimo
                ? $"{numero} es un número primo."
                : $"{numero} no es un número primo.";

            return View();
        }
    }
}
