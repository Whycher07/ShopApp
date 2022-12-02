using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index() 
        { 
            
            return View(); 
        
        }
    }
}
