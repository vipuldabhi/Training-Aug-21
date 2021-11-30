using Day17.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DoctorWithPatientController : ControllerBase
    {
        private readonly IDoctorWithPatientRepository _doctorWithPatientRepository;
        public DoctorWithPatientController(IDoctorWithPatientRepository doctorWithPatientRepository)
        {
            _doctorWithPatientRepository = doctorWithPatientRepository;
        }

        [HttpGet]
        public IActionResult GetAllDoctorsWithPatientData()
        {
            if (_doctorWithPatientRepository.GetAll().Any())
            {
                return Ok(_doctorWithPatientRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }
    }
}
