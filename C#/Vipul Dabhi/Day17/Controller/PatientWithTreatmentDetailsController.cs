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
    public class PatientWithTreatmentDetailsController : ControllerBase
    {
        private readonly IPatientWithTreatmentDetailsRepository _patientWithTreatmentDetailsRepository;
        public PatientWithTreatmentDetailsController(IPatientWithTreatmentDetailsRepository patientWithTreatmentDetailsRepository)
        {
            _patientWithTreatmentDetailsRepository = patientWithTreatmentDetailsRepository;
        }

        [HttpGet]
        public IActionResult GetAllPatientDataWithMadicineDetails()
        {
            if (_patientWithTreatmentDetailsRepository.GetAll().Any())
            {
                return Ok(_patientWithTreatmentDetailsRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }
    }
}
