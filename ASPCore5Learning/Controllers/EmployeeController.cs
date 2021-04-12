using BusinessLogicWebBridge.IBusinessLogicWebBridge;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore5Learning.Controllers
{
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeWebBridge _employeeWebBridge;

        public EmployeeController(IEmployeeWebBridge employeeWebBridge)
        {
            _employeeWebBridge = employeeWebBridge;
        }
        public ViewResult Index()
        {
            return View();
        }
        [Route("Employees")]
        public ViewResult EmployeeList(int? id)
        { 
            var employees = _employeeWebBridge.GetAllEmployees();
            return View("~/Views/Employee/Employees.cshtml", employees);
        }
        [Route("{Id}")]
        public ViewResult EmployeeById(int Id)
        {
            var employees = _employeeWebBridge.GetEmployeeById(Id);
            return View(employees);
        }

    }
}
