using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using BusinessModule.Services.Abstract;
using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services {
	public class MealService : IMealService {

		private IMealRepository _mealRepository;
		private IMealMapper _mealMapper;

		public MealService(IMealRepository mealRepository, IMealMapper mealMapper) {
			_mealRepository = mealRepository;
			_mealMapper = mealMapper;
		}

		public void AddMeal(MealDTO mealDTO) {
			var meal = _mealMapper.GetMealFromMealDTO(mealDTO);
			_mealRepository.AddMeal(meal);

			mealDTO.Id = meal.MealId;
		}

		public void DeleteMeal(MealDTO mealDTO) {
			var meal = _mealMapper.GetMealFromMealDTO(mealDTO);
			_mealRepository.DeleteMeal(meal);
		}

		public MealDTO GetMealById(int id) {
			var meal = _mealRepository.GetMealsById(id);
			var result = _mealMapper.GetMealDTOFromMeal(meal);
			return result;
		}

		public IEnumerable<MealDTO> GetMeals() {
			var meals = _mealRepository.GetMeals();
			IList<MealDTO> list = new List<MealDTO>();

			foreach (var meal in meals) {
				list.Add(_mealMapper.GetMealDTOFromMeal(meal));
			}

			return list;
		}

		public void UpdateMeal(MealDTO mealDTO) {
			var meal = _mealMapper.GetMealFromMealDTO(mealDTO);
			_mealRepository.UpdateMeal(meal);
		}
	}
}
