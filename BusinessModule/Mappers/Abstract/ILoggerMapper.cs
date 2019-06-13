using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers.Abstract {
	public interface ILoggerMapper {
		LoggerDTO GetLoggerDTOFromLogger(Logger logger);
		Logger GetLoggerFromLoggerDTO(LoggerDTO loggerDTO);
	}
}
