using Microsoft.AspNetCore.Mvc;

namespace MyRecipe.Controllers
{
    public class HomeController : Controller
    {
         public IActionResult Index() {
            return Content("Sono la index della home");
         }
    }
}