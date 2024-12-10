using Microsoft.AspNetCore.Mvc;

namespace WebApplication1_HW_04_12_2024_ADD.Controllers
{
    public class FitnessController : Controller
    {
        public IActionResult Index()
        {
            return View(FitnessData.Categories);
        }

        public IActionResult Category(int id)
        {
            var category = FitnessData.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        public IActionResult Article(int id)
        {
            var article = FitnessData.Articles.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            var category = FitnessData.Categories.FirstOrDefault(c => c.Articles.Any(a => a.Id == id));
            ViewBag.CategoryId = category?.Id;

            return View(article);
        }
    }
}
