using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicWebBridge.IBusinessLogicWebBridge
{
    public interface IEmployeeWebBridge
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        
    }
}
