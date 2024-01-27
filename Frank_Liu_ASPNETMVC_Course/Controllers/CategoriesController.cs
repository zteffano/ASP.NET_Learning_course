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
			ViewBag.Action = "edit";

			var category = CategoriesRepository.GetCategoryById(id.HasValue?id.Value:0);

			return View(category);
		}
		
		public IActionResult Add()
		{
			
            ViewBag.Action = "add";
            return View();
		}



		[HttpPost]
		public IActionResult Edit(Category category)
		{
			if (!ModelState.IsValid) {
			
				return View(category);
			}
			CategoriesRepository.UpdateCategory(category.Id, category);
			return RedirectToAction(nameof(Index));
		}

		[HttpPost]
		public IActionResult Add(Category category)
		{
		 if (!ModelState.IsValid)
			{
				return View(category);
			}

			CategoriesRepository.AddCategory(category);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Delete(int Id)
		{
            Console.WriteLine("--> Called Delete Controller");
            CategoriesRepository.DeleteCategory(Id);
			return RedirectToAction(nameof(Index));
		}
	}
}
