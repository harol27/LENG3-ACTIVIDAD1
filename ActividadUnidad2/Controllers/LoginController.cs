using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string usuario, string contrasena)
        {
            // Credenciales válidas
            string userValido = "docente";
            string passValido = "P@ssw0rd";

            if (usuario == userValido && contrasena == passValido)
            {
                // Redirige a la acción Bienvenido
                return RedirectToAction("Bienvenido");
            }
            else
            {
                ViewBag.Error = "Usuario incorrecto";
                return View();
            }
        }

        public IActionResult Bienvenido()
        {
            ViewBag.Mensaje = "Bienvenido";
            return View();
        }
    }
}
