using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15_Assignment.Models;

namespace Day15_Assignment.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(long employeeId);
        bool PostEmployee(Employee employee);
        bool PutEmployee(Employee employee);
        bool DeleteEmployee(long employeeId);
    }
}