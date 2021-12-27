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
    public class TuesdayLunchMenuController : ControllerBase
    {
        private readonly ITuesdayLunchMenuRepository _tuesdayLunchMenuRepository;
        public TuesdayLunchMenuController(ITuesdayLunchMenuRepository tuesdayLunchMenuRepository)
        {
            _tuesdayLunchMenuRepository = tuesdayLunchMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllTuesdayLunchMenu()
        {
            if (_tuesdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_tuesdayLunchMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_tuesdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_tuesdayLunchMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertTuesdayLunchItem(TuesdayLunchMenu tuesdayLunchMenu)
        {
            var result = _tuesdayLunchMenuRepository.Create(tuesdayLunchMenu);
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
        public IActionResult UpdateTuesdayLunchMenu(int ItemId, TuesdayLunchMenu tuesdayLunchMenu)
        {
            var result = _tuesdayLunchMenuRepository.Update(ItemId, tuesdayLunchMenu);
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
        public IActionResult DeleteTuesdayLunchItem(int ItemId)
        {
            var result = _tuesdayLunchMenuRepository.Delete(ItemId);
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
