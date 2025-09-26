using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class FacturaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(decimal monto, string opcion)
        {
            decimal subtotal = monto;
            decimal impuestoOdescuento = 0;
            decimal total = 0;
            string detalle = "";

            if (opcion == "ITBIS")
            {
                impuestoOdescuento = subtotal * 0.18m;
                total = subtotal + impuestoOdescuento;
                detalle = $"ITBIS (18%): {impuestoOdescuento:C}";
            }
            else if (opcion == "Descuento")
            {
                impuestoOdescuento = subtotal * 0.15m;
                total = subtotal - impuestoOdescuento;
                detalle = $"Descuento (15%): {impuestoOdescuento:C}";
            }

            ViewBag.Subtotal = subtotal;
            ViewBag.Detalle = detalle;
            ViewBag.Total = total;

            return View();
        }
    }
}
