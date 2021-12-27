using E_Tiffin_Service.Models;
using E_Tiffin_Service.Repository;
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
    public class SundayLunchMenuController : ControllerBase
    {
        private readonly ISundayLunchMenuRepository _sundayLunchMenuRepository;
        public SundayLunchMenuController(ISundayLunchMenuRepository sundayLunchMenuRepository)
        {
            _sundayLunchMenuRepository = sundayLunchMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllSundayLunchMenu()
        {
            if (_sundayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_sundayLunchMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_sundayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_sundayLunchMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertSundayLunchItem(SundayLunchMenu sundayLunchMenu)
        {
            var result = _sundayLunchMenuRepository.Create(sundayLunchMenu);
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
        public IActionResult UpdateSundayLunchMenu(int ItemId, SundayLunchMenu sundayLunchMenu)
        {
            var result = _sundayLunchMenuRepository.Update(ItemId, sundayLunchMenu);
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
        public IActionResult DeleteSundayLunchItem(int ItemId)
        {
            var result = _sundayLunchMenuRepository.Delete(ItemId);
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
