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
    public class TuesdayDinnerMenuController : ControllerBase
    {
        private readonly ITuesdayDinnerMenuRepository _tuesdayDinnerMenuRepository;
        public TuesdayDinnerMenuController(ITuesdayDinnerMenuRepository tuesdayDinnerMenuRepository)
        {
            _tuesdayDinnerMenuRepository = tuesdayDinnerMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllTuesdayDinnerMenu()
        {
            if (_tuesdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_tuesdayDinnerMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_tuesdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_tuesdayDinnerMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertTuesdayDinnerItem(TuesdayDinnerMenu tuesdayDinnnerMenu)
        {
            var result = _tuesdayDinnerMenuRepository.Create(tuesdayDinnnerMenu);
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
        public IActionResult UpdateTuesdayDinnerMenu(int ItemId, TuesdayDinnerMenu tuesdayDinnerMenu)
        {
            var result = _tuesdayDinnerMenuRepository.Update(ItemId, tuesdayDinnerMenu);
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
        public IActionResult DeleteTuesdayDinnerItem(int ItemId)
        {
            var result = _tuesdayDinnerMenuRepository.Delete(ItemId);
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
