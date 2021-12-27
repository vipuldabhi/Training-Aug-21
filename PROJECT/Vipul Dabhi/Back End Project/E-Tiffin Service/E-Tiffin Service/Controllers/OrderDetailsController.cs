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
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        public OrderDetailsController(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }

        [HttpGet]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult GetAllData()
        {
            if (_orderDetailsRepository.GetAll().Any())
            {
                return Ok(_orderDetailsRepository.GetAll());
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
            if (_orderDetailsRepository.GetAll().Any())
            {
                return Ok(_orderDetailsRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertData(OrderDetail orderDetails)
        {
            var result = _orderDetailsRepository.Create(orderDetails);
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

        public IActionResult UpdateData(int ItemId, OrderDetail orderDetails)
        {
            var result = _orderDetailsRepository.Update(ItemId, orderDetails);
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
            var result = _orderDetailsRepository.Delete(ItemId);
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
