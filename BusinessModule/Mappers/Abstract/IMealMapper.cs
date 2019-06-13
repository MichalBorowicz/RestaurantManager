using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers.Abstract {
	public interface IMealMapper {
		MealDTO GetMealDTOFromMeal(Meals meals);
		Meals GetMealFromMealDTO(MealDTO mealDTO);
	}
}
