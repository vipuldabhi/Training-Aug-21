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
    public class WednesdayLunchMenuController : ControllerBase
    {
        private readonly IWednesdayLunchMenuRepository _wednesdayLunchMenuRepository;
        public WednesdayLunchMenuController(IWednesdayLunchMenuRepository wednesdayLunchMenuRepository)
        {
            _wednesdayLunchMenuRepository = wednesdayLunchMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllWednesdayLunchMenu()
        {
            if (_wednesdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_wednesdayLunchMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_wednesdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_wednesdayLunchMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertWednesdayLunchItem(WednesdayLunchMenu wednesdayLunchMenu)
        {
            var result = _wednesdayLunchMenuRepository.Create(wednesdayLunchMenu);
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
        public IActionResult UpdateWednesdayLunchMenu(int ItemId, WednesdayLunchMenu wednesdayLunchMenu)
        {
            var result = _wednesdayLunchMenuRepository.Update(ItemId, wednesdayLunchMenu);
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
        public IActionResult DeleteWednesdayLunchItem(int ItemId)
        {
            var result = _wednesdayLunchMenuRepository.Delete(ItemId);
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
