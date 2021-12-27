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
    //[Authorize(Roles = UserRoles.Admin +","+ UserRoles.DeliveryBoy)]
    //[Authorize(Roles = UserRoles.DeliveryBoy)]
    [Authorize(Roles = "admin,deliveryboy")]

    public class DeliveryStatusController : ControllerBase
    {
        private readonly IDeliveryStatusRepository _deliveryStatusRepository;
        public DeliveryStatusController(IDeliveryStatusRepository deliveryStatusRepository)
        {
            _deliveryStatusRepository = deliveryStatusRepository;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            if (_deliveryStatusRepository.GetAll().Any())
            {
                return Ok(_deliveryStatusRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_deliveryStatusRepository.GetAll().Any())
            {
                return Ok(_deliveryStatusRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertData(DeliveryStatus deliveryStatus)
        {
            var result = _deliveryStatusRepository.Create(deliveryStatus);
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
        public IActionResult UpdateData(int ItemId, DeliveryStatus deliveryStatus)
        {
            var result = _deliveryStatusRepository.Update(ItemId, deliveryStatus);
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
        public IActionResult DeleteData(int ItemId)
        {
            var result = _deliveryStatusRepository.Delete(ItemId);
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
