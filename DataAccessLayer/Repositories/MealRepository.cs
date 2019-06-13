using DataAccessLayer.Model;
using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories {
	public class MealRepository : BaseRepository<Meals>, IMealRepository {
		public void AddMeal(Meals meals) {
			Add(meals);
		}

		public void DeleteMeal(Meals meals) {
			Delete(meals);
		}

		public IEnumerable<Meals> GetMeals() {
			return GetAll();
		}

		public Meals GetMealsById(int id) {
			return Get(x => x.MealId == id);
		}

		public void UpdateMeal(Meals meals) {
			Update(meals);
		}
	}
}
