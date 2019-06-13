using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessModule.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantManager.Controllers
{
    public class LoggerController : Controller
    {
		private ILoggerService loggerService;

		public LoggerController(ILoggerService loggerService) {
			this.loggerService = loggerService;
		}
		public IActionResult GetAll()
        {
			var locals = this.loggerService.GetLoggers();
			return View(locals);
		}
    }
}