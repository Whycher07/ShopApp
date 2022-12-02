using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class OrderLine : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
