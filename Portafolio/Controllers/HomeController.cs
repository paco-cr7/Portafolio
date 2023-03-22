using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //El viewbag solo sirve oara pasar informacion a la vista, es dinamico osea toma cualquier atributo que le pongamos
            //ViewBag.Nombre = "Francisco Sánchez";
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel(){ Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "IMCINE",
                    Descripcion = "ERP Interno en ASP.NET",
                    Link = "https://convocatorias.imcine.gob.mx/focine/ficcion/",
                    ImagenURL = "/imagenes/CDI.png"
                },

                new Proyecto
                {
                    Titulo = "IMCINE",
                    Descripcion = "Sistemas de convocatorias FOCINE",
                    Link = "https://convocatorias.imcine.gob.mx/focine/ficcion/",
                    ImagenURL = "/imagenes/FOCINE.png"
                },

                new Proyecto
                {
                    Titulo = "GRUPO PISA",
                    Descripcion = "Sistema baso en Core Banking con VisualBasic .NET",
                    Link = "https://www.grupopisa.com.mx/",
                    ImagenURL = "/imagenes/GrupoPISA.png"
                },

                new Proyecto
                {
                    Titulo = "Grupo Cynthus",
                    Descripcion = "Sistema de hojas de calculo Woking Papers",
                    Link = "https://www.cynthus.com.mx/",
                    ImagenURL = "/imagenes/GrupoCynthus.png"
                }
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}