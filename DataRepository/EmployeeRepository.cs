using DataRepository.IDataRepository;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        public EmployeeRepository()
        {

        }

        public List<Employee> GetAllEmployees()
        {
            employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Varun", Salary = 60000},
                new Employee { Id = 2, Name = "XYZ", Salary = 50000},
                new Employee { Id = 3, Name = "ABC", Salary = 50000},
                new Employee{ Id = 4, Name = "asd", Salary = 60000},
                new Employee { Id = 5, Name = "XadsYZ", Salary = 50000},
                new Employee { Id = 6, Name = "AdfdfBC", Salary = 50000},
                new Employee{ Id = 7, Name = "Vfdfdfarun", Salary = 60000},
                new Employee { Id = 8, Name = "dsdsd", Salary = 50000},
                new Employee { Id = 9, Name = "ArtrtrBC", Salary = 50000}
            };
            return employeeList;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = GetAllEmployees().Find(x => x.Id == id);
            if (employee != null)
                return employee;
            else;
            return null;
        }
    }
}
