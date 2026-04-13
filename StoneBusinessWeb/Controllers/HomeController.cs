using Microsoft.AspNetCore.Mvc;
using StoneBusinessWeb.Models;

namespace StoneBusinessWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View(new ContactoViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contacto(ContactoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            TempData["MensajeExito"] = "Gracias por contactarnos. Te responderemos pronto.";
            return RedirectToAction(nameof(Contacto));
        }
    }
}