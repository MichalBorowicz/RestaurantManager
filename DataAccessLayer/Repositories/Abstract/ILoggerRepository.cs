using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.Abstract {
	public interface ILoggerRepository {
		IEnumerable<Logger> GetLoggers();
	}
}
