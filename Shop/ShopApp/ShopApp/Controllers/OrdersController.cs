using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
