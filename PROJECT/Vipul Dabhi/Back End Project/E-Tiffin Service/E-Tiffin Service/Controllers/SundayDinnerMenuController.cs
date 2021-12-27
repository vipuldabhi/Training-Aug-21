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
    public class SundayDinnerMenuController : ControllerBase
    {
        private readonly ISundayDinnerMenuRepository _sundayDinnerMenuRepository;
        public SundayDinnerMenuController(ISundayDinnerMenuRepository sundayDinnerMenuRepository)
        {
            _sundayDinnerMenuRepository = sundayDinnerMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllSundayDinnerMenu()
        {
            if (_sundayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_sundayDinnerMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_sundayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_sundayDinnerMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertSundayDinnerItem(SundayDinnerMenu sundayDinnerMenu)
        {
            var result = _sundayDinnerMenuRepository.Create(sundayDinnerMenu);
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
        public IActionResult UpdateSundayDinnerMenu(int ItemId, SundayDinnerMenu sundayDinnerMenu)
        {
            var result = _sundayDinnerMenuRepository.Update(ItemId, sundayDinnerMenu);
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
        public IActionResult DeleteSundayDinnerItem(int ItemId)
        {
            var result = _sundayDinnerMenuRepository.Delete(ItemId);
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
