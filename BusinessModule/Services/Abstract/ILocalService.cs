using BusinessModule.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services.Abstract {
	public interface ILocalService {
		LocalDTO GetLocalById(int id);
		void AddLocal(LocalDTO localDTO);
		IEnumerable<LocalDTO> GetLocals();
		void DeleteLocal(LocalDTO localDTO);
		void UpdateLocal(LocalDTO localDTO);
	}
}
