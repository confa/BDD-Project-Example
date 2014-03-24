using System;
using System.Web.Mvc;
using AdvancedTesting.Enums;
using AdvancedTesting.Models;
using AdvancedTesting.Services;
using Newtonsoft.Json;

namespace AdvancedTesting.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private static readonly DataService _DataService = new DataService();

        public ActionResult Index()
        {
            var recipes = _DataService.GetAll();
            return View(recipes);
        }

        public ActionResult GetRecipe(int id)
        {
            var recipe = _DataService.Get(id);
            return View("Recipe", recipe);
        }

        [HttpPost]
        public ActionResult AddRecipe(Recipe recipe)
        {
            recipe.Author = User.Identity.Name;
            return RedirectToAction(_DataService.Insert(recipe) ? "Index" : "Error");
        }

        public string GetAllIngredients()
        {
            return JsonConvert.SerializeObject(Enum.GetValues(typeof(IngredientType)));
        }

        public ActionResult RemoveRecipe(int id)
        {
            _DataService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
