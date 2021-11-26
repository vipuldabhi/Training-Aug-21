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
    [Route("api/emps/{employeeid:long}/child/assignments")]
    [ApiController]
    public class assignmentsController : ControllerBase
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public assignmentsController(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }
        public IActionResult GetAssignments([FromRoute] long employeeid)
        {
            if (_assignmentRepository.GetAssignments(employeeid).Any())
            {
                return Ok(_assignmentRepository.GetAssignments(employeeid));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{assignmentId}")]
        public IActionResult GetAssignment(long assignmentId, [FromRoute] long employeeid)
        {
            if (_assignmentRepository.GetAssignment(assignmentId, employeeid) != null)
            {
                return Ok(_assignmentRepository.GetAssignment(assignmentId, employeeid));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut()]
        public IActionResult PutAssignment(Assignment assignment)
        {
            if (_assignmentRepository.PutAssignment(assignment) == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{delAssignmentId}")]
        public IActionResult DeleteAssignment(long delAssignmentId)
        {
            if (_assignmentRepository.DeleteAssignment(delAssignmentId) == true)
            {
                return Ok(_assignmentRepository.DeleteAssignment(delAssignmentId));
            }
            else
            {
                return NotFound();
            }
        }
    }
}