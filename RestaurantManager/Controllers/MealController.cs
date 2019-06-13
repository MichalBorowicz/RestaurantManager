using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessModule.Models;
using BusinessModule.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantManager.Controllers
{
    public class MealController : Controller
    {
		private IMealService mealService;

		public MealController(IMealService mealService) {
			this.mealService = mealService;
		}

		public IActionResult GetAll() {
			var meals = this.mealService.GetMeals();
			return View(meals);
		}

		public IActionResult Create(MealDTO meal) {
			return View(meal);
		}

		[HttpPost]
		public IActionResult Create(int? id, MealDTO meal) {
			var result = new MealDTO {
				Id = meal.Id,
				Name = meal.Name,
				Price = meal.Price
			};
			mealService.AddMeal(meal);
			return RedirectToAction("GetAll", "Meal");
		}

		public IActionResult Delete(MealDTO meal) {
			return View(meal);
		}
		[HttpPost]
		public IActionResult Delete(int? id, MealDTO meal) {
			mealService.DeleteMeal(meal);
			return RedirectToAction("GetAll", "Meal");
		}

		public IActionResult Details(MealDTO meal) {
			return View(mealService.GetMealById(meal.Id));
		}

		public IActionResult Edit(MealDTO meal) {
			return View(mealService.GetMealById(meal.Id));
		}
		[HttpPost]
		public IActionResult Edit(int? id, MealDTO meal) {
			mealService.UpdateMeal(meal);
			return RedirectToAction("GetAll", "Meal");
		}
	}
}