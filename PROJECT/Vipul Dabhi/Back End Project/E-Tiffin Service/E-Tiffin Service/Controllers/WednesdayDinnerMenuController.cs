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
    public class WednesdayDinnerMenuController : ControllerBase
    {
        private readonly IWednesdayDinnerMenuRepository _wednesdayDinnerMenuRepository;
        public WednesdayDinnerMenuController(IWednesdayDinnerMenuRepository wednesdayDinnerMenuRepository)
        {
            _wednesdayDinnerMenuRepository = wednesdayDinnerMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllWednesdayDinnerMenu()
        {
            if (_wednesdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_wednesdayDinnerMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_wednesdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_wednesdayDinnerMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertWednesdayDinnerItem(WednesdayDinnerMenu wednesdayDinnerMenu)
        {
            var result = _wednesdayDinnerMenuRepository.Create(wednesdayDinnerMenu);
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
        public IActionResult UpdateWednesdayDinnerMenu(int ItemId, WednesdayDinnerMenu wednesdayDinnerMenu)
        {
            var result = _wednesdayDinnerMenuRepository.Update(ItemId, wednesdayDinnerMenu);
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
        public IActionResult DeleteWednesdayDinnerItem(int ItemId)
        {
            var result = _wednesdayDinnerMenuRepository.Delete(ItemId);
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
