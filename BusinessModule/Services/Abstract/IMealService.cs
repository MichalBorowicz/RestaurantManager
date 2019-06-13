using BusinessModule.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services.Abstract {
	public interface IMealService {
		MealDTO GetMealById(int id);
		void AddMeal(MealDTO mealDTO);
		IEnumerable<MealDTO> GetMeals();
		void DeleteMeal(MealDTO mealDTO);
		void UpdateMeal(MealDTO mealDTO);
	}
}
