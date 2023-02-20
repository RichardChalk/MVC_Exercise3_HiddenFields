using HiddenFields.Models;
using HiddenFields.Viewmodels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HiddenFields.Controllers
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
            var IndexVM = new IndexViewModel();
            return View(IndexVM);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel indexVM)
        {
            indexVM.Counter +=1;
            return View(indexVM);
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