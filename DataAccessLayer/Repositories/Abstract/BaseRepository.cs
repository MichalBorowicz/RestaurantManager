using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Abstract {
	public abstract class BaseRepository<T> where T : class {
		public T Get(Func<T, bool> func) {
			using (var context = new RestaurantManagerContext()) {
				return context.Set<T>().FirstOrDefault(func);
			}
		}

		public T GetWithMany(Func<T, bool> func, string with1, string with2) {
			using (var context = new RestaurantManagerContext()) {
				return context.Set<T>()
					.Include(with1)
					.Include(with2)
					.FirstOrDefault(func);
			}
		}

		public IEnumerable<T> GetBy(Func<T, bool> func) {
			using (var context = new RestaurantManagerContext()) {
				return context.Set<T>().Where(func).ToList();
			}
		}

		public IEnumerable<T> GetByWith(Func<T, bool> by, string with) {
			using (var context = new RestaurantManagerContext()) {
				return context.Set<T>().Include(with).Where(by).ToList();
			}
		}

		public IEnumerable<T> GetAll() {
			using (var context = new RestaurantManagerContext()) {
				return context.Set<T>().ToList();
			}
		}

		public void Add(T model) {
			using (var context = new RestaurantManagerContext()) {
				context.Set<T>().Attach(model);
				context.Set<T>().Add(model);
				context.SaveChanges();
			}
		}

		public void Delete(T model) {
			using (var context = new RestaurantManagerContext()) {
				context.Set<T>().Attach(model);
				context.Set<T>().Remove(model);
				context.SaveChanges();
			}
		}

		public void Update(T model) {
			using(var context = new RestaurantManagerContext()) {
				context.Set<T>().Attach(model);
				context.Set<T>().Update(model);
				context.SaveChanges();
			}
		}
	}
}
