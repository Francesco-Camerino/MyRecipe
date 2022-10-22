using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyRecipe.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index() {
            return Content("Sono Index");
        }
        public IActionResult Detail(string id) {
            return Content($"Sono Detail, ho ricevuto l'id {id}");
        }
    }
}