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
    public class MondayDinnerMenuController : ControllerBase
    {
        private readonly IMondayDinnerMenuRepository _mondayDInnerMenuRepository;
        public MondayDinnerMenuController(IMondayDinnerMenuRepository mondayDInnerMenuRepository)
        {
            _mondayDInnerMenuRepository = mondayDInnerMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllMondayDinnerMenu()
        {
            if (_mondayDInnerMenuRepository.GetAll().Any())
            {
                return Ok(_mondayDInnerMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_mondayDInnerMenuRepository.GetAll().Any())
            {
                return Ok(_mondayDInnerMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertMondayLunchItem(MondayDinnerMenu mondayDinnerMenu)
        {
            var result = _mondayDInnerMenuRepository.Create(mondayDinnerMenu);
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
        public IActionResult UpdateMondayDinnerMenu(int ItemId, MondayDinnerMenu mondayDinnerMenu)
        {
            var result = _mondayDInnerMenuRepository.Update(ItemId, mondayDinnerMenu);
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
        public IActionResult DeleteMondayDinnerItem(int ItemId)
        {
            var result = _mondayDInnerMenuRepository.Delete(ItemId);
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
