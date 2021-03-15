using Aplicacao.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.web.Models;

namespace Aplicacao.web.Controllers
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
            return View(Dados.LISTA_CLIENTES);
        }

        public IActionResult novo_cliente()
        {
            //apresenta o formulario para adicionar novo clientes
            return View();
        }

        [HttpPost]
        public IActionResult novo_cliente(Cliente item)
        {
            //adicionar um novo cliente a lista
            Dados.LISTA_CLIENTES.Add(item);

            return RedirectToAction("index");
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
