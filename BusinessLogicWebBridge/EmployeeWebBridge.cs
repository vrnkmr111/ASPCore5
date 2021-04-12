using BusinessLogicWebBridge.IBusinessLogicWebBridge;
using DataRepository.IDataRepository;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicWebBridge
{
    public class EmployeeWebBridge : IEmployeeWebBridge
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeWebBridge(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }
    }
}
