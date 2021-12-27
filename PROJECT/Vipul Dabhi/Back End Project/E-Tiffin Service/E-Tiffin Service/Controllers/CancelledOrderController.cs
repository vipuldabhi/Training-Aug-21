using E_Tiffin_Service.Models;
using E_Tiffin_Service.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = UserRoles.Admin)]

    public class CancelledOrderController : ControllerBase
    {
        private readonly ICancelledOrderRepository _cancelledOrderRepository;
        public CancelledOrderController(ICancelledOrderRepository cancelledOrderRepository)
        {
            _cancelledOrderRepository = cancelledOrderRepository;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            if (_cancelledOrderRepository.GetAll().Any())
            {
                return Ok(_cancelledOrderRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }
    }
}
