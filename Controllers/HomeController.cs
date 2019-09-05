using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CookingEShop.Models;
using CookingEShop.ViewModels;

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
            
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to the E-Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}