using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IEmergencyRepository _emergencyRepository;

        public StudentController(IStudentRepository studentRepository, IEmergencyRepository emergencyRepository)
        {
            _studentRepository = studentRepository;
            _emergencyRepository = emergencyRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            try
            {
                return Ok(await _studentRepository.GetStudents());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error From Retrivng Data");
            }
        }

        [HttpGet("emergency")]
        public async Task<ActionResult> GetEmergencyContacts()
        {
            try
            {
                return Ok(await _emergencyRepository.GetEmergencyContacts());
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetStudentById(int id)
        {

            try
            {
                return Ok(await _studentRepository.GetStudentById(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error From Retrivng Data");
            }
        }

        [HttpPost("")]
        public async Task<ActionResult> AddStudent(Student student)
        {
            try
            {
                return Ok(await _studentRepository.AddStudent(student));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateStudent([FromBody]Student student,int id)
        {
            try
            {
                return Ok(await _studentRepository.UpdateStudent(student, id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            try
            {
                return Ok(await _studentRepository.DeleteStudent(id));
            }
            catch
            {
                throw;
            }
        }
        
    }
}
