﻿using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositorioProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, RepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            //_repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.obtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
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