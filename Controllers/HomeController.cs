using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CookingEShop.Models;

namespace CookingEShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pie)
        {
            _pieRepository = pie;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}