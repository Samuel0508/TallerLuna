using Microsoft.AspNetCore.Mvc;

namespace TallerLuna.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult agenda()
        {
            return View();
        }

        public IActionResult clientes()
        {
            return View();
        }

        public IActionResult facturacion()
        {
            return View();
        }

        public IActionResult gastos()
        {
            return View();
        }

        public IActionResult ingresos()
        {
            return View();
        }
        public IActionResult inventario()
        {
            return View();
        }
        public IActionResult reservar()
        {
            return View();
        }
        public IActionResult servicio()
        {
            return View();
        }

    }
}
