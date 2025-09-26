using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string nombre, DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha cumplido años este año
            if (DateTime.Now < fechaNacimiento.AddYears(edad))
                edad--;

            ViewBag.Mensaje = $"Hola, {nombre}. Tienes {edad} años y tu año de nacimiento es {fechaNacimiento.Year}.";

            return View();
        }
    }
}