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
  
    public class MondayLunchMenuController : ControllerBase
    {
        private readonly IMondayLunchMenuRepository _mondayLunchMenuRepository;
        public MondayLunchMenuController(IMondayLunchMenuRepository mondayLunchMenuRepository)
        {
            _mondayLunchMenuRepository = mondayLunchMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllMondayLunchMenu()
        {
            if (_mondayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_mondayLunchMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_mondayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_mondayLunchMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertMondayLunchItem(MondayLunchMenu mondayLunchMenu)
        {
            var result = _mondayLunchMenuRepository.Create(mondayLunchMenu);
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
        public IActionResult UpdateMondayLunchMenu(int ItemId, MondayLunchMenu mondayLunchMenu)
        {
            var result = _mondayLunchMenuRepository.Update(ItemId, mondayLunchMenu);
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
        public IActionResult DeleteMondayLunchItem(int ItemId)
        {
            var result = _mondayLunchMenuRepository.Delete(ItemId);
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
