using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.Abstract {
	public class LoggerRepository : BaseRepository<Logger>, ILoggerRepository {
		public IEnumerable<Logger> GetLoggers() {
			return GetAll();
		}
	}
}
