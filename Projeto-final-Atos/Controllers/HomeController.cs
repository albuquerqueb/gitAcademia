using Microsoft.AspNetCore.Mvc;
using Projeto_final_Atos.Models;
using System.Diagnostics;

namespace Projeto_final_Atos.Controllers
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
            return View();
        }
        public IActionResult Pacote()
        {
            return View();
        }
        public IActionResult Atendimento()
        {
            return View();
        }
        public IActionResult Usuario()
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