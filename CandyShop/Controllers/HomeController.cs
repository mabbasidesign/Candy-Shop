﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CandyShop.Models;
using CandyShop.ViewModels;

namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyRepository _candyRepository;

        public HomeController(ICandyRepository candyRepository)
        {
            _candyRepository = candyRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CandyOnSale = _candyRepository.GetCandyOnSale
            };

            return View(homeViewModel);
        }

       
    }
}
