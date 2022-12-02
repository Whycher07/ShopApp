using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
