using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers {
	public class LocalMapper : ILocalMapper {
		public LocalDTO GetLocalDTOFromLocals(Locals locals) {
			var result = new LocalDTO {
				Id = locals.LocalId,
				Adress = locals.City + " " + locals.Street
			};

			return result;
		}

		public Locals GetLocalsFromLokalDTO(LocalDTO localDTO) {
			var result = new Locals {
				LocalId = localDTO.Id,
				City = localDTO.Adress?.Split(' ')[0],
				Street = localDTO.Adress?.Split(' ')[1]
			};

			return result;
		}
	}
}
