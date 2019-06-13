using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.Abstract {
	public interface IWorkerRepository {
		Workers GetWorkersById(int id);
		void AddWorkers(Workers workers);
		IEnumerable<Workers> GetWorkers();
		void DeleteWorker(Workers workers);
		void UpdateWorker(Workers workers);
	}
}
