using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localization_Session.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IStringLocalizer<EmployeeController> _localizer;

        public EmployeeController(IStringLocalizer<EmployeeController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult NewEmployee()
        {
            ViewData["message"]= _localizer["test"];
            return View();
        }

        public IActionResult EmployeeList()
        {
            return View();
        }
    }
}
