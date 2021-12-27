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
    public class FridayLunchMenuController : ControllerBase
    {
        private readonly IFridayLunchMenuRepository _fridayLunchMenuRepository;
        public FridayLunchMenuController(IFridayLunchMenuRepository fridayLunchMenuRepository)
        {
            _fridayLunchMenuRepository = fridayLunchMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllFridayLunchMenu()
        {
            if (_fridayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_fridayLunchMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_fridayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_fridayLunchMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertFridayLunchItem(FridayLunchMenu fridayLunchMenu)
        {
            var result = _fridayLunchMenuRepository.Create(fridayLunchMenu);
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
        public IActionResult UpdateFridayLunchMenu(int ItemId, FridayLunchMenu fridayLunchMenu)
        {
            var result = _fridayLunchMenuRepository.Update(ItemId, fridayLunchMenu);
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
        public IActionResult DeleteFridayLunchItem(int ItemId)
        {
            var result = _fridayLunchMenuRepository.Delete(ItemId);
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
