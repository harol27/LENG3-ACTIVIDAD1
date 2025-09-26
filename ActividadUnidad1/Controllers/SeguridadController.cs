using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace ActividadUnidad1.Controllers
{
    public class SeguridadController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string clave)
        {
            bool claveFuerte = false;

            if (!string.IsNullOrEmpty(clave))
            {
                claveFuerte =
                    clave.Length >= 8 &&
                    Regex.IsMatch(clave, "[A-Z]") &&
                    Regex.IsMatch(clave, "[a-z]") &&
                    Regex.IsMatch(clave, "[0-9]");
            }

            ViewBag.Resultado = claveFuerte
                ? "La contraseña es segura ✅"
                : "La contraseña NO es segura ❌";

            return View();
        }
    }
}
