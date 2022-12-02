using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();


                }
    }
}
