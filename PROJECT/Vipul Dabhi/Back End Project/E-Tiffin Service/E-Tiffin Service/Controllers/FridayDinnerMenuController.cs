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
    [Authorize(Roles = UserRoles.DeliveryBoy)]

    public class FridayDinnerMenuController : ControllerBase
    {
        private readonly IFridayDinnerMenuRepository _fridayDinnerMenuRepository;
        public FridayDinnerMenuController(IFridayDinnerMenuRepository fridayDinnerMenuRepository)
        {
            _fridayDinnerMenuRepository = fridayDinnerMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllFridayDinnerMenu()
        {
            if (_fridayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_fridayDinnerMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_fridayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_fridayDinnerMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertFridayDinnerItem(FridayDinnerMenu fridayDinnerMenu)
        {
            var result = _fridayDinnerMenuRepository.Create(fridayDinnerMenu);
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
        public IActionResult UpdateFridayDinnerMenu(int ItemId, FridayDinnerMenu fridayDinnerMenu)
        {
            var result = _fridayDinnerMenuRepository.Update(ItemId, fridayDinnerMenu);
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
        public IActionResult DeleteFridayDinnerItem(int ItemId)
        {
            var result = _fridayDinnerMenuRepository.Delete(ItemId);
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
