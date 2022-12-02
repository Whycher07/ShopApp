using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class CustomersController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
