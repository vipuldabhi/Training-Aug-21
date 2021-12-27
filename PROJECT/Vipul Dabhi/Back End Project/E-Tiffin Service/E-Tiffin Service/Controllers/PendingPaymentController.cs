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

    public class PendingPaymentController : ControllerBase
    {
        private readonly IPendingPaymentRepository _pendingPaymentRepository;
        public PendingPaymentController(IPendingPaymentRepository pendingPaymentRepository)
        {
            _pendingPaymentRepository = pendingPaymentRepository;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            if (_pendingPaymentRepository.GetAll().Any())
            {
                return Ok(_pendingPaymentRepository.GetAll());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{Id}")]
        public IActionResult UpdatePendingPaymentStatus(int Id, PendingPayment pendingPayment)
        {
            var result = _pendingPaymentRepository.Update(Id, pendingPayment);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{Id}")]
        public IActionResult GetItemById(int Id)
        {
            if (_pendingPaymentRepository.GetAll().Any())
            {
                return Ok(_pendingPaymentRepository.GetById(Id));
            }
            else
            {
                return NotFound();
            }

        }

    }
}
