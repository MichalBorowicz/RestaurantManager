using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using BusinessModule.Services.Abstract;
using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services {
	public class LocalService : ILocalService {

		private ILocalRepository _localRepository;
		private ILocalMapper _localMapper;

		public LocalService(ILocalRepository localRepository, ILocalMapper localMapper) {
			_localRepository = localRepository;
			_localMapper = localMapper;
		}
		public void AddLocal(LocalDTO localDTO) {
			var local = _localMapper.GetLocalsFromLokalDTO(localDTO);
			_localRepository.AddLocal(local);

			localDTO.Id = local.LocalId;
		}

		public void DeleteLocal(LocalDTO localDTO) {
			var local = _localMapper.GetLocalsFromLokalDTO(localDTO);
			_localRepository.DeleteLocal(local);
		}

		public LocalDTO GetLocalById(int id) {
			var local = _localRepository.GetLocalsById(id);
			var result = _localMapper.GetLocalDTOFromLocals(local);
			return result;
		}

		public IEnumerable<LocalDTO> GetLocals() {
			var locals = _localRepository.GetLocals();
			IList<LocalDTO> list = new List<LocalDTO>();

			foreach (var local in locals) {
				list.Add(_localMapper.GetLocalDTOFromLocals(local));
			}

			return list;
		}

		public void UpdateLocal(LocalDTO localDTO) {
			var local = _localMapper.GetLocalsFromLokalDTO(localDTO);
			_localRepository.UpdateLocal(local);
		}
	}
}
