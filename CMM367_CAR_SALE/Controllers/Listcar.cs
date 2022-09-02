using Microsoft.AspNetCore.Mvc;
using CMM367_CAR_SALE.Models;

namespace CMM367_CAR_SALE.Controllers
{
    public class Listcar : Controller
    {
        public IActionResult Index()
        {
            var carlist = new List<CarModel>();
            carlist.Add(new CarModel { CarImg = "123.png", CarName = "กุ๊กๆกู๋", Price = "฿500" });
            carlist.Add(new CarModel { CarImg = "124.png", CarName = "ABC", Price = "฿500" });
            carlist.Add(new CarModel { CarImg = "125.png", CarName = "ไก่จ๋า", Price = "฿600" });
            carlist.Add(new CarModel { CarImg = "126.png", CarName = "ไก่ย่าง", Price = "฿800" });
            return View(carlist);
        }
    }
}
