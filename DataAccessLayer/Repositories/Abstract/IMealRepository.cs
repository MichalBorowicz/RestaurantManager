using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.Abstract {
	public interface IMealRepository {
		Meals GetMealsById(int id);
		void AddMeal(Meals meals);
		IEnumerable<Meals> GetMeals();
		void DeleteMeal(Meals meals);
		void UpdateMeal(Meals meals);
	}
}
