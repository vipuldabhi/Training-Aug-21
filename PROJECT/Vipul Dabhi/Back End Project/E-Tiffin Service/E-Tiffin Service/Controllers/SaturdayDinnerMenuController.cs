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
    public class SaturdayDinnerMenuController : ControllerBase
    {
        private readonly ISaturdayDinnerMenuRepository _saturdayDinnerMenuRepository;
        public SaturdayDinnerMenuController(ISaturdayDinnerMenuRepository saturdayDinnerMenuRepository)
        {
            _saturdayDinnerMenuRepository = saturdayDinnerMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllSaturdayDinnerMenu()
        {
            if (_saturdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_saturdayDinnerMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_saturdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_saturdayDinnerMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertSaturdayDinnerItem(SaturdayDinnerMenu saturdayDinnerMenu)
        {
            var result = _saturdayDinnerMenuRepository.Create(saturdayDinnerMenu);
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
        public IActionResult UpdateSaturdayDinnerMenu(int ItemId, SaturdayDinnerMenu saturdayDinnerMenu)
        {
            var result = _saturdayDinnerMenuRepository.Update(ItemId, saturdayDinnerMenu);
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
        public IActionResult DeleteSaturdayDinnerItem(int ItemId)
        {
            var result = _saturdayDinnerMenuRepository.Delete(ItemId);
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
