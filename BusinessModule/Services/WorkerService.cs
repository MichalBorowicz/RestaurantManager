using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using BusinessModule.Services.Abstract;
using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services {
	public class WorkerService : IWorkerService {

		private IWorkerRepository _workerRepository;
		private IWorkerMapper _workerMapper;

		public WorkerService(IWorkerRepository workerRepository, IWorkerMapper workerMapper) {
			_workerRepository = workerRepository;
			_workerMapper = workerMapper;
		}
		public void AddWorker(WorkerDTO workerDTO) {
			var worker = _workerMapper.GetWorkersFromWorkerDTO(workerDTO);
			_workerRepository.AddWorkers(worker);

			workerDTO.Id = worker.WorkerId;
		}

		public void DeleteWorker(WorkerDTO workerDTO) {
			var worker = _workerMapper.GetWorkersFromWorkerDTO(workerDTO);
			_workerRepository.DeleteWorker(worker);
		}

		public WorkerDTO GetWorkerById(int id) {
			var worker = _workerRepository.GetWorkersById(id);
			var result = _workerMapper.GetWorkerDTOFromWorkers(worker);
			return result;
		}

		public IEnumerable<WorkerDTO> GetWorkers() {
			var workers = _workerRepository.GetWorkers();
			IList<WorkerDTO> list = new List<WorkerDTO>();

			foreach (var worker in workers) {
				list.Add(_workerMapper.GetWorkerDTOFromWorkers(worker));
			}

			return list;
		}

		public void UpdateWorker(WorkerDTO workerDTO) {
			var worker = _workerMapper.GetWorkersFromWorkerDTO(workerDTO);
			_workerRepository.UpdateWorker(worker);
		}
	}
}
