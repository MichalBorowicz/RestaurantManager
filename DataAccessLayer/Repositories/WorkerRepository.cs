using DataAccessLayer.Model;
using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories {
	public class WorkerRepository : BaseRepository<Workers>, IWorkerRepository {
		public void AddWorkers(Workers workers) {
			Add(workers);
		}

		public void DeleteWorker(Workers workers) {
			Delete(workers);
		}

		public IEnumerable<Workers> GetWorkers() {
			return GetAll();
		}

		public Workers GetWorkersById(int id) {
			return Get(x => x.WorkerId == id);
		}

		public void UpdateWorker(Workers workers) {
			Update(workers);
		}
	}
}
