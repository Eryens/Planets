﻿using Microsoft.AspNetCore.Mvc;
using Planets.DAL;
using Planets.Models;
using Planets.Models.AbstractClasses;
using Planets.Models.Classes;
using System.Diagnostics;

namespace Planets.Controllers
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
            SolarSystem model = MockData.GetSolarSystem();

            return View(model);
        }

        public IActionResult Tooltip(string name)
        {
            Planet model;
            try
            {
                model = MockData.GetSolarSystem().Planets.First(c => c.Name == name);
            }
            catch
            {
                throw new ArgumentException("The given planet name is not valid");
            }
            return PartialView("_PlanetTooltip", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}