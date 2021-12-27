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
    public class PaymentStatusController : ControllerBase
    {
        private readonly IPaymentStatusRepository _paymentStatusRepository;
        public PaymentStatusController(IPaymentStatusRepository paymentStatusRepository)
        {
            _paymentStatusRepository = paymentStatusRepository;
        }

        [HttpGet]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult GetAllData()
        {
            if (_paymentStatusRepository.GetAll().Any())
            {
                return Ok(_paymentStatusRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult GetItemById(int ItemId)
        {
            if (_paymentStatusRepository.GetAll().Any())
            {
                return Ok(_paymentStatusRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertData(PaymentStatus paymentStatus)
        {
            var result = _paymentStatusRepository.Create(paymentStatus);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{ItemId}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateData(int ItemId, PaymentStatus paymentStatus)
        {
            var result = _paymentStatusRepository.Update(ItemId, paymentStatus);
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
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult DeleteData(int ItemId)
        {
            var result = _paymentStatusRepository.Delete(ItemId);
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
