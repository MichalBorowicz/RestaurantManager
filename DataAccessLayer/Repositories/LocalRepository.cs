using DataAccessLayer.Model;
using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories {
	public class LocalRepository : BaseRepository<Locals>, ILocalRepository {
		public void AddLocal(Locals locals) {
			Add(locals);
		}

		public void DeleteLocal(Locals locals) {
			Delete(locals);
		}

		public IEnumerable<Locals> GetLocals() {
			return GetAll();
		}

		public Locals GetLocalsById(int id) {
			return Get(x => x.LocalId == id);
		}

		public void UpdateLocal(Locals locals) {
			Update(locals);
		}
	}
}
