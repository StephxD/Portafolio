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

            //var Persona = new Persona()
            //{
            //    Nombre = "Stephanie Oviedo Gonzalez",
            //    Edad = 18
            //};
            ///*  ViewBag.name = "Stephanie Oviedo Gonzalez";*/
            //return View(/*"Index","Stephanie"*/ Persona);

            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }
        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { 
                
            new Proyecto
        { 
            Titulo="Amazon",
            Descripcion="E-commerce",
            Link="",
            ImagenURL="/imagenes/amazon.png"
            
            },
            new Proyecto
        {
            Titulo="Amazon",
            Descripcion="E-commerce",
            Link="",
            ImagenURL=""

            },
            new Proyecto
        {
            Titulo="Amazon",
            Descripcion="E-commerce",
            Link="",
            ImagenURL=""

            },
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