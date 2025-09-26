using Microsoft.AspNetCore.Mvc;
using ActividadUnidad1.Models;

namespace ActividadUnidad1.Controllers
{
    public class PresentacionController : Controller
    {
        [HttpGet]
        public IActionResult Saludo()
        {
            var modelo = new PresentacionViewModel
            {
                Nombre = "Harold Hernandez",
                Matricula = "SD-2022-02261"
            };
            return View(modelo);
        }
    }
}
