using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessModule.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using BusinessModule.Models;

namespace RestaurantManager.Controllers {
	public class WorkerController : Controller {

		private IWorkerService workerService;

		public WorkerController(IWorkerService workerService) {
			this.workerService = workerService;
		}

		public IActionResult GetAll() {
			var workers = this.workerService.GetWorkers();
			return View(workers);
		}

		public IActionResult Create(WorkerDTO worker) {
			return View(worker);
		}
		[HttpPost]
		public IActionResult Create(int? id, WorkerDTO worker) {
			var result = new WorkerDTO {
				Id = worker.Id,
				FullName = worker.FullName,
				Pesel = worker.Pesel
			};
			workerService.AddWorker(worker);
			return RedirectToAction("GetAll", "Worker");
		}

		public IActionResult Delete(WorkerDTO worker) {
			return View(worker);
		}
		[HttpPost]
		public IActionResult Delete(int? id, WorkerDTO worker) {
			workerService.DeleteWorker(worker);
			return RedirectToAction("GetAll", "Worker");
		}

		public IActionResult Edit(WorkerDTO worker) {
			return View(workerService.GetWorkerById(worker.Id));
		}
		[HttpPost]
		public IActionResult Edit(int? id, WorkerDTO worker) {
			workerService.UpdateWorker(worker);
			return RedirectToAction("GetAll", "Worker");
		}

		public IActionResult Details(WorkerDTO worker) {
			return View(workerService.GetWorkerById(worker.Id));
		}
	}
}