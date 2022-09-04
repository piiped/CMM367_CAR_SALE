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
        public IActionResult Car01()
        {
            return View();
        }
        public IActionResult Car02()
        {
            return View();
        }
        public IActionResult Car03()
        {
            return View();
        }
        public IActionResult Car04()
        {
            return View();
        }
        public IActionResult Car05()
        {
            return View();
        }
        public IActionResult Car06()
        {
            return View();
        }

        [HttpPost]
        public IActionResult car1()
        {
            int price = 452000;
            int down,month,finance, increase, year, totalincrease, total = 0;
            var result = 0;
           
                down = Convert.ToInt32(HttpContext.Request.Form["txdown"].ToString());
                month = Convert.ToInt32(HttpContext.Request.Form["txmonth"].ToString());
                finance = price - down;
                increase = finance * 5 / 100;
                year = month / 12;
                totalincrease = increase * year;
                total = finance + totalincrease;
                result = total / month;

            ViewBag.RESULT = result.ToString();
            ViewBag.Month = month.ToString();

            return View("Car01");
        }
        public IActionResult car2()
        {
            int price = 430000;
            int down, month, finance, increase, year, totalincrease, total = 0;
            var result = 0;

            down = Convert.ToInt32(HttpContext.Request.Form["txdown"].ToString());
            month = Convert.ToInt32(HttpContext.Request.Form["txmonth"].ToString());
            finance = price - down;
            increase = finance * 5 / 100;
            year = month / 12;
            totalincrease = increase * year;
            total = finance + totalincrease;
            result = total / month;

            ViewBag.RESULT = result.ToString();
            ViewBag.Month = month.ToString();

            return View("Car02");
        }
        public IActionResult car3()
        {
            int price = 398000;
            int down, month, finance, increase, year, totalincrease, total = 0;
            var result = 0;

            down = Convert.ToInt32(HttpContext.Request.Form["txdown"].ToString());
            month = Convert.ToInt32(HttpContext.Request.Form["txmonth"].ToString());
            finance = price - down;
            increase = finance * 5 / 100;
            year = month / 12;
            totalincrease = increase * year;
            total = finance + totalincrease;
            result = total / month;

            ViewBag.RESULT = result.ToString();
            ViewBag.Month = month.ToString();

            return View("Car03");
        }
        public IActionResult car4()
        {
            int price = 406900;
            int down, month, finance, increase, year, totalincrease, total = 0;
            var result = 0;

            down = Convert.ToInt32(HttpContext.Request.Form["txdown"].ToString());
            month = Convert.ToInt32(HttpContext.Request.Form["txmonth"].ToString());
            finance = price - down;
            increase = finance * 5 / 100;
            year = month / 12;
            totalincrease = increase * year;
            total = finance + totalincrease;
            result = total / month;

            ViewBag.RESULT = result.ToString();
            ViewBag.Month = month.ToString();

            return View("Car04");
        }
        public IActionResult car5()
        {
            int price = 351000;
            int down, month, finance, increase, year, totalincrease, total = 0;
            var result = 0;

            down = Convert.ToInt32(HttpContext.Request.Form["txdown"].ToString());
            month = Convert.ToInt32(HttpContext.Request.Form["txmonth"].ToString());
            finance = price - down;
            increase = finance * 5 / 100;
            year = month / 12;
            totalincrease = increase * year;
            total = finance + totalincrease;
            result = total / month;

            ViewBag.RESULT = result.ToString();
            ViewBag.Month = month.ToString();

            return View("Car05");
        }
        public IActionResult car6()
        {
            int price = 362000;
            int down, month, finance, increase, year, totalincrease, total = 0;
            var result = 0;

            down = Convert.ToInt32(HttpContext.Request.Form["txdown"].ToString());
            month = Convert.ToInt32(HttpContext.Request.Form["txmonth"].ToString());
            finance = price - down;
            increase = finance * 5 / 100;
            year = month / 12;
            totalincrease = increase * year;
            total = finance + totalincrease;
            result = total / month;

            ViewBag.RESULT = result.ToString();
            ViewBag.Month = month.ToString();

            return View("Car06");
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