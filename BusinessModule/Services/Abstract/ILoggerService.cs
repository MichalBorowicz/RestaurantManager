using BusinessModule.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services.Abstract {
	public interface ILoggerService {
		IEnumerable<LoggerDTO> GetLoggers();
	}
}
