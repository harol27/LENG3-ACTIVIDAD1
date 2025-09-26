using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ActividadUnidad1.Controllers
{
    public class AnagramaController : Controller
    {
        [HttpGet]
        public IActionResult Verificar(string texto1, string texto2)
        {
            if (string.IsNullOrEmpty(texto1) || string.IsNullOrEmpty(texto2))
            {
                ViewBag.Resultado = "Debes ingresar ambos textos en la URL. Ejemplo: /Anagrama/Verificar?texto1=roma&texto2=amor";
                return View();
            }

            string normal1 = new string(texto1.ToLower().Replace(" ", "").OrderBy(c => c).ToArray());
            string normal2 = new string(texto2.ToLower().Replace(" ", "").OrderBy(c => c).ToArray());

            bool esAnagrama = normal1 == normal2;

            ViewBag.Resultado = esAnagrama
                ? $"✅ \"{texto1}\" y \"{texto2}\" son anagramas."
                : $"❌ \"{texto1}\" y \"{texto2}\" NO son anagramas.";

            return View();
        }
    }
}
