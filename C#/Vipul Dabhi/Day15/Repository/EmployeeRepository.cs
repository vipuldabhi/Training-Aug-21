using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15_Assignment.Models;

namespace Day15_Assignment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeApiDbContext _context;
        public EmployeeRepository(EmployeeApiDbContext context)
        {
            _context = context;
        }

        public bool DeleteEmployee(long employeeId)
        {
            try
            {
                var employee = _context.Employees.Find(employeeId);
                if (employee != null)
                {
                    employee.isActive = false;
                    var assignments = _context.Assignments.Where(a => a.EmployeeRefId == employeeId).ToList();
                    foreach (var assignment in assignments)
                    {
                        assignment.isActive = false;
                    }
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            try
            {
                return _context.Employees.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Employee GetEmployee(long employeeId)
        {
            try
            {
                return _context.Employees.Find(employeeId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        public bool PostEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool PutEmployee(Employee employee)
        {
            try
            {
                var oldemployee = _context.Employees.Find(employee.EmployeeId);
                if (oldemployee != null)
                {
                    oldemployee.FirstName = employee.FirstName;
                    oldemployee.assignments = employee.assignments;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}