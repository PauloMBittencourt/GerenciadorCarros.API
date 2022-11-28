//using AutoVendas.Models;
using GerenciadorCarros.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoVendas.Controllers
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
            ViewBag.Oferta1Nome = "Sandero";
            ViewBag.Valor1 = 45000.00;
            ViewBag.img1 = "https://revistacarro.com.br/wp-content/uploads/2021/11/Sandero-S-Edition-2022_1.jpg";
            ViewBag.Desc1 = "Sandero muito bem conservado";
            ViewBag.Oferta2Nome = "Onix Plus";
            ViewBag.Valor2 = 90000.00;
            ViewBag.img2 = "https://t.ctcdn.com.br/-YZpPwhLZC1SPfc2kQNUyrNe_XY=/1400x788/smart/i359505.jpeg";
            ViewBag.Desc2 = "Onix Plus 0 Km com arcondocionado e outras garantias";
            ViewBag.Oferta3Nome = "Ranger";
            ViewBag.Valor3 = 190000.00;
            ViewBag.img3 = "https://cdn.motor1.com/images/mgl/mMAwYe/s1/new-ford-ranger-raptor-unofficial-renderings-by-kolesa.ru.webp";
            ViewBag.Desc3 = "Ford Ranger semi nova apenas usada para lazer.";

            return View();
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