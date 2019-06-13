using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers {
	public class MealMapper : IMealMapper {
		public MealDTO GetMealDTOFromMeal(Meals meals) {
			var result = new MealDTO {
				Id = meals.MealId,
				Name = meals.Name,
				Price = meals.Price
			};

			return result;
		}

		public Meals GetMealFromMealDTO(MealDTO mealDTO) {
			var result = new Meals {
				MealId = mealDTO.Id,
				Name = mealDTO.Name,
				Price = mealDTO.Price
			};

			return result;
		}
	}
}
