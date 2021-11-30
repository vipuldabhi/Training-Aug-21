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
    public class PatientTakesMadicineController : ControllerBase
    {
        private readonly IPatientTakesMadicineRepository _patientTakesMadicineRepository;
        public PatientTakesMadicineController(IPatientTakesMadicineRepository patientTakesMadicineRepository)
        {
            _patientTakesMadicineRepository = patientTakesMadicineRepository;
        }

        [HttpGet]
        public IActionResult GetAllPatientDataWithMadicineDetails()
        {
            if (_patientTakesMadicineRepository.GetAll().Any())
            {
                return Ok(_patientTakesMadicineRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }
    }
}
