using System;
using Microsoft.AspNetCore.Mvc;
using Proyecto_ASP_NET_CORE.Models;

namespace Proyecto_ASP_NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreacion = 2018;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Mau School";
            escuela.Pais = "Ecuador";
            escuela.Ciudad = "Riobamba";
            escuela.Dirección = "Mi casa";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            ViewBag.CosaDinamica = "Ejemplo";
            return View(escuela);
        }
    }
}