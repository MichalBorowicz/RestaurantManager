using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers {
	public class WorkerMapper : IWorkerMapper {
		public WorkerDTO GetWorkerDTOFromWorkers(Workers workers) {
			var result = new WorkerDTO {
				Id = workers.WorkerId,
				FullName = workers.Name + " " + workers.Surname,
				Pesel = workers.Pesel
			};

			return result;
		}

		public Workers GetWorkersFromWorkerDTO(WorkerDTO workerDTO) {
			var result = new Workers {
				WorkerId = workerDTO.Id,
				Name = workerDTO.FullName?.Split(' ')[0],
				Surname = workerDTO.FullName?.Split(' ')[1],
				Pesel = workerDTO.Pesel
			};

			return result;
		}
	}
}
