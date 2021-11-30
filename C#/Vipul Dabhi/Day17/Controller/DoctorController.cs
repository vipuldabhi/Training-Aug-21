using Day17.Models;
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
    [Authorize(Roles = UserRoles.Admin)]
    //[Authorize]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult GetAllDoctorsData()
        {
            if (_doctorRepository.GetAll().Any())
            {
                return Ok(_doctorRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertDoctorData(Doctor doctor)
        {
            var result = _doctorRepository.Create(doctor);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{doctorId}")]
        public IActionResult UpdateDoctorData(int doctorId, Doctor doctor)
        {
            var result = _doctorRepository.Update(doctorId, doctor);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctorData(int doctorId)
        {
            var result = _doctorRepository.Delete(doctorId);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
