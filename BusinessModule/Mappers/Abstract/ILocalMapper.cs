using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers.Abstract {
	public interface ILocalMapper {
		LocalDTO GetLocalDTOFromLocals(Locals locals);
		Locals GetLocalsFromLokalDTO(LocalDTO localDTO);
	}
}
