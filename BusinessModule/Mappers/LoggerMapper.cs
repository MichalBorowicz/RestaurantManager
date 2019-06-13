using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Mappers {
	public class LoggerMapper : ILoggerMapper {
		public LoggerDTO GetLoggerDTOFromLogger(Logger logger) {
			var result = new LoggerDTO {
				Id = logger.LoggerId,
				Date = logger.OperationDate.Value,
				Description = logger.OperationDescription
			};

			return result;
		}

		public Logger GetLoggerFromLoggerDTO(LoggerDTO loggerDTO) {
			var result = new Logger {
				LoggerId = loggerDTO.Id,
				OperationDate = loggerDTO.Date,
				OperationDescription = loggerDTO.Description
			};

			return result;
		}
	}
}
