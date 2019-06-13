using BusinessModule.Mappers.Abstract;
using BusinessModule.Models;
using BusinessModule.Services.Abstract;
using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModule.Services {
	public class LoggerService : ILoggerService {

		private ILoggerRepository _loggerRepository;
		private ILoggerMapper _loggerMapper;

		public LoggerService(ILoggerRepository loggerRepository, ILoggerMapper loggerMapper) {
			_loggerRepository = loggerRepository;
			_loggerMapper = loggerMapper;
		}

		public IEnumerable<LoggerDTO> GetLoggers() {
			var loggers = _loggerRepository.GetLoggers();
			IList<LoggerDTO> list = new List<LoggerDTO>();

			foreach (var logger in loggers) {
				list.Add(_loggerMapper.GetLoggerDTOFromLogger(logger));
			}

			return list;
		}
	}
}
