using Frank_Liu_ASPNETMVC_Course.Models;
using Microsoft.AspNetCore.Mvc;

namespace Frank_Liu_ASPNETMVC_Course.Controllers
{
	public class CategoriesController : Controller
	{
		public IActionResult Index()
		{
			var categories = CategoriesRepository.GetCategories();
			return View(categories);
		}

		public IActionResult Edit(int? id)
		{

			var category = CategoriesRepository.GetCategoryById(id.HasValue?id.Value:0);

			return View(category);
		}
	}
}
