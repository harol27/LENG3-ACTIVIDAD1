using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class Numero3Controller : Controller
    {
        [HttpGet]
        public IActionResult Fibonacci()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fibonacci(int numero)
        {
            bool pertenece = EsFibonacci(numero);

            ViewBag.Resultado = pertenece
                ? $"{numero} pertenece a la serie de Fibonacci."
                : $"{numero} no pertenece a la serie de Fibonacci.";

            return View();
        }

        private bool EsFibonacci(int n)
        {
            if (n < 0) return false;

            // Un número pertenece a Fibonacci si y solo si
            // 5*n^2 + 4 o 5*n^2 - 4 es un cuadrado perfecto.
            return EsCuadradoPerfecto(5 * n * n + 4) || EsCuadradoPerfecto(5 * n * n - 4);
        }

        private bool EsCuadradoPerfecto(int x)
        {
            int raiz = (int)Math.Sqrt(x);
            return raiz * raiz == x;
        }
    }
}
