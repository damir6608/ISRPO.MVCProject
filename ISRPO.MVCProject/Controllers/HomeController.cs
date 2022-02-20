using ISRPO.MVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ISRPO.MVCProject.Models;

namespace ISRPO.MVCProject.Controllers
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

        public IActionResult Faktorial(int n)
        {
            Faktorial b = new Models.Faktorial();
            if (TryValidateModel(n)) 
            {
                b.answer = b.Calculate(n); 
            }
            
            return View("Index", b) ;
        }

        public IActionResult SecondTask(List<int> Height)
        {
            var s = new Students();
            s.answer = s.IsDescending(Height) ? "В порядке убывания" : "Не в порядке убывания";
            return View("Privacy", s);
        }

        public IActionResult ThirdTask()
        {
            return View("ThirdTask");
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
