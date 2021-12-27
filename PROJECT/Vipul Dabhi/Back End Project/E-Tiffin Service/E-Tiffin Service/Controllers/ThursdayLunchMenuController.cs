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
    public class ThursdayLunchMenuController : ControllerBase
    {
        private readonly IThursdayLunchMenuRepository _thursdayLunchMenuRepository;
        public ThursdayLunchMenuController(IThursdayLunchMenuRepository thursdayLunchMenuRepository)
        {
            _thursdayLunchMenuRepository = thursdayLunchMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllThursdayLunchMenu()
        {
            if (_thursdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_thursdayLunchMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_thursdayLunchMenuRepository.GetAll().Any())
            {
                return Ok(_thursdayLunchMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertThursdayLunchItem(ThursdayLunchMenu thursdayLunchMenu)
        {
            var result = _thursdayLunchMenuRepository.Create(thursdayLunchMenu);
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
        public IActionResult UpdateThursdayLunchMenu(int ItemId, ThursdayLunchMenu thursdayLunchMenu)
        {
            var result = _thursdayLunchMenuRepository.Update(ItemId, thursdayLunchMenu);
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
        public IActionResult DeleteThursdayLunchItem(int ItemId)
        {
            var result = _thursdayLunchMenuRepository.Delete(ItemId);
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
