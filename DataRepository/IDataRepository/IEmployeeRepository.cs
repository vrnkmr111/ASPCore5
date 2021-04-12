using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.IDataRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}
