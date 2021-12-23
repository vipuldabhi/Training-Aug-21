using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmergencyController : ControllerBase
    {
        private readonly IEmergencyRepository _emergencyRepository;

        public EmergencyController(IEmergencyRepository emergencyRepository)
        {
            _emergencyRepository = emergencyRepository;
        }

        [HttpGet]
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

    }
}
