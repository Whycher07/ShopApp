using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ShopApp.Controllers
{
    public class UnitController:Controller   
    {
        public IActionResult Index() 
        { 
            return View(); 
        }
    }
}
