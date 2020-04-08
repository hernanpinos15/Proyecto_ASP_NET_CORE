using System;
using Microsoft.AspNetCore.Mvc;
using Proyecto_ASP_NET_CORE.Models;

namespace Proyecto_ASP_NET_CORE.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "POO"
            };
            
            ViewBag.CosaDinamica = "Ejemplo";
            ViewBag.Fecha = DateTime.Now;
            return View(asignatura);
        }
    }
}