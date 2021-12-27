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

    public class CancellationStatusController : ControllerBase
    {
        private readonly ICancellationStatusRepository _cancellationStatusRepository;
        public CancellationStatusController(ICancellationStatusRepository cancellationStatusRepository)
        {
            _cancellationStatusRepository = cancellationStatusRepository;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            if (_cancellationStatusRepository.GetAll().Any())
            {
                return Ok(_cancellationStatusRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_cancellationStatusRepository.GetAll().Any())
            {
                return Ok(_cancellationStatusRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult InsertData(CancellationStatus cancellationStatus)
        {
            var result = _cancellationStatusRepository.Create(cancellationStatus);
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

        public IActionResult UpdateData(int ItemId, CancellationStatus cancellationStatus)
        {
            var result = _cancellationStatusRepository.Update(ItemId, cancellationStatus);
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
            var result = _cancellationStatusRepository.Delete(ItemId);
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
