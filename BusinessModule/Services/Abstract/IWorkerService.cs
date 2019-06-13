using BusinessModule.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services.Abstract {
	public interface IWorkerService {
		WorkerDTO GetWorkerById(int id);
		void AddWorker(WorkerDTO workerDTO);
		IEnumerable<WorkerDTO> GetWorkers();
		void DeleteWorker(WorkerDTO workerDTO);
		void UpdateWorker(WorkerDTO workerDTO);
	}
}
