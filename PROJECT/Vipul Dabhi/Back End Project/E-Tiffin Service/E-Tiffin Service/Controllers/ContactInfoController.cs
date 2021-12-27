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
    public class ContactInfoController : ControllerBase
    {
        private readonly IContactInfoRepository _contactInfoRepository;
        public ContactInfoController(IContactInfoRepository contactInfoRepository)
        {
            _contactInfoRepository = contactInfoRepository;
        }

        [HttpGet]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult GetAllData()
        {
            if (_contactInfoRepository.GetAll().Any())
            {
                return Ok(_contactInfoRepository.GetAll());
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
            if (_contactInfoRepository.GetAll().Any())
            {
                return Ok(_contactInfoRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertData(ContactInfo contactInfo)
        {
            var result = _contactInfoRepository.Create(contactInfo);
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

        public IActionResult UpdateData(int ItemId, ContactInfo contactInfo)
        {
            var result = _contactInfoRepository.Update(ItemId, contactInfo);
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
            var result = _contactInfoRepository.Delete(ItemId);
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
