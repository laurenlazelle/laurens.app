
using laurens.app.Models;
using Microsoft.AspNetCore.Mvc;

namespace laurens.app.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult Index()
        {
            return View(new AnimalModel());
        }

        [HttpPost]
        public IActionResult Index(AnimalModel model)
        {
            return View(new AnimalModel());
        }
    }
}