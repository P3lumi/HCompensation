using HCompensation.Models;
using HCompensation.Models.ViewModels;
using HCompensation.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarOwnerService _ownerService;
        private readonly IFuelStationService _fuelService;

        public HomeController(ILogger<HomeController> logger, ICarOwnerService ownerService, IFuelStationService fuelService)
        {
            _logger = logger;
            _ownerService = ownerService;
            _fuelService = fuelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddFuelStation()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFuelStation(FuelStationVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var response = await _fuelService.AddFuelStation(model);
            if (!response)
            {
                return View(model);
            }
            return RedirectToAction("Submit");
        }

        public IActionResult AddCarOwner()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCarOwner(CarOwnerVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var response = await _ownerService.AddCarOwner(model);
            if (!response)
            {
                return View(model);
            }
            return RedirectToAction("Submit");
        }

        public IActionResult Submit()
        {
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
