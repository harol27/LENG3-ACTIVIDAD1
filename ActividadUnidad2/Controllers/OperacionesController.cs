using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class OperacionesController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(double valor1, double valor2, string operacion)
        {
            double resultado = 0;
            string mensaje = "";

            switch (operacion)
            {
                case "Sumar":
                    resultado = valor1 + valor2;
                    mensaje = $"{valor1} + {valor2} = {resultado}";
                    break;
                case "Restar":
                    resultado = valor1 - valor2;
                    mensaje = $"{valor1} - {valor2} = {resultado}";
                    break;
                case "Multiplicar":
                    resultado = valor1 * valor2;
                    mensaje = $"{valor1} × {valor2} = {resultado}";
                    break;
                case "Dividir":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                        mensaje = $"{valor1} ÷ {valor2} = {resultado}";
                    }
                    else
                    {
                        mensaje = "Error: No se puede dividir entre 0.";
                    }
                    break;
                case "Potencia":
                    resultado = Math.Pow(valor1, valor2);
                    mensaje = $"{valor1}^{valor2} = {resultado}";
                    break;
            }

            ViewBag.Resultado = mensaje;
            return View();
        }
    }
}
