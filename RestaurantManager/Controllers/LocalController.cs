using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer;
using DataAccessLayer.Model;
using BusinessModule.Services.Abstract;
using BusinessModule.Models;

namespace RestaurantManager.Controllers {
	public class LocalController : Controller {
		private ILocalService localService;

		public LocalController(ILocalService localService) {
			this.localService = localService;
		}

		public IActionResult GetAll() {
			var locals = this.localService.GetLocals();
			return View(locals);
		}

		public IActionResult Create(LocalDTO local) {
			return View(local);
		}

		[HttpPost]
		public IActionResult Create(int? id, LocalDTO local) {
			var result = new LocalDTO {
				Id = local.Id,
				Adress = local.Adress
			};
			localService.AddLocal(local);
			return RedirectToAction("GetAll", "Local");
		}

		public IActionResult Delete(LocalDTO local) {
			return View(local);
		}
		[HttpPost]
		public IActionResult Delete(int? id, LocalDTO local) {
			localService.DeleteLocal(local);
			return RedirectToAction("GetAll", "Local");
		}

		public IActionResult Details(LocalDTO local) {
			return View(localService.GetLocalById(local.Id));
		}

		public IActionResult Edit(LocalDTO local) {
			return View(localService.GetLocalById(local.Id));
		}
		[HttpPost]
		public IActionResult Edit(int? id, LocalDTO local) {
			localService.UpdateLocal(local);
			return RedirectToAction("GetAll", "Local");
		}
	}
}
