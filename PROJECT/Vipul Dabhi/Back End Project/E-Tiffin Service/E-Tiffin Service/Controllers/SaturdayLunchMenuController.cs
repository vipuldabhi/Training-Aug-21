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
    public class SaturdayLunchMenuController : ControllerBase
    {
        private readonly ISaturdayLunchMenuRepository _saturdayLunchMenuRepository;
        public SaturdayLunchMenuController(ISaturdayLunchMenuRepository saturdayLunchMenuRepository)
        {
            _saturdayLunchMenuRepository = saturdayLunchMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllSaturdayLunchMenu()
        {
            if (_saturdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_saturdayLunchMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_saturdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_saturdayLunchMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertSaturdayLunchItem(SaturdayLunchMenu saturdayLunchMenu)
        {
            var result = _saturdayLunchMenuRepository.Create(saturdayLunchMenu);
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
        public IActionResult UpdateSaturdayLunchMenu(int ItemId, SaturdayLunchMenu saturdayLunchMenu)
        {
            var result = _saturdayLunchMenuRepository.Update(ItemId, saturdayLunchMenu);
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
        public IActionResult DeleteSaturdayLunchItem(int ItemId)
        {
            var result = _saturdayLunchMenuRepository.Delete(ItemId);
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
