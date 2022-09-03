using CMM367_CAR_SALE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CMM367_CAR_SALE.Controllers
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
        [HttpPost]
        public IActionResult calculate()
        {

            int price = 0;
            int down = 0;
            int finance = 0;
            int increase = finance * (5 /100);
            int month = 0;
            int year = 0;
            int totalincrease = 0;
            int total = 0;
            var result = 0;

            
            price = Convert.ToInt32(HttpContext.Request.Form["txt1"].ToString());
            down = Convert.ToInt32(HttpContext.Request.Form["txt2"].ToString());
            finance = price - down;
            increase = finance * 5 / 100;
            month = Convert.ToInt32(HttpContext.Request.Form["txt3"].ToString());
            year = month / 12;
            totalincrease = increase * year;
            total = finance + totalincrease;
            result = total / month;

            ViewBag.RESULT = result.ToString();
            ViewBag.Price = price.ToString();
            ViewBag.Down = down.ToString();
            ViewBag.Finance = finance.ToString();
            ViewBag.Increase = increase.ToString();
            ViewBag.Month = month.ToString();
            ViewBag.Year = year.ToString();
            ViewBag.Totalincrease = totalincrease.ToString();
            ViewBag.Total = total.ToString();
            return View("Index");

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