using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers.Abstract {
	public interface IWorkerMapper {
		WorkerDTO GetWorkerDTOFromWorkers(Workers workers);
		Workers GetWorkersFromWorkerDTO(WorkerDTO workerDTO);
	}
}
