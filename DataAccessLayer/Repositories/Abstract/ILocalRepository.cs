using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.Abstract {
	public interface ILocalRepository {
		Locals GetLocalsById(int id);
		void AddLocal(Locals locals);
		IEnumerable<Locals> GetLocals();
		void DeleteLocal(Locals locals);
		void UpdateLocal(Locals locals);
	}
}
