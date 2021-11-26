using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15_Assignment.Models;
using Day15_Assignment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day15_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("{employeeId}")]
        public IActionResult GetEmployee(long employeeId)
        {
            if (_employeeRepository.GetEmployee(employeeId) != null)
            {
                return Ok(_employeeRepository.GetEmployee(employeeId));
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet()]
        public IActionResult GetAllEmployees()
        {
            if (_employeeRepository.GetAllEmployees().Any())
            {
                return Ok(_employeeRepository.GetAllEmployees());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost()]
        public IActionResult PostEmployee(Employee employee)
        {
            if (_employeeRepository.PostEmployee(employee) == true)
            {
                return Ok(_employeeRepository.PostEmployee(employee));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut()]
        public IActionResult PutEmployee(Employee employee)
        {
            if (_employeeRepository.PutEmployee(employee) == true)
            {
                return Ok(_employeeRepository.PutEmployee(employee));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{empId}")]
        public IActionResult DeleteEmployee(long empId)
        {
            if (_employeeRepository.DeleteEmployee(empId) == true)
            {
                return Ok(_employeeRepository.DeleteEmployee(empId));
            }
            else
            {
                return NotFound();
            }
        }
    }
}