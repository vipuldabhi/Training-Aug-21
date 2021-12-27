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
    public class ThursdayDinnerMenuController : ControllerBase
    {
        private readonly IThursdayDinnerMenuRepository _thursdayDinnerMenuRepository;
        public ThursdayDinnerMenuController(IThursdayDinnerMenuRepository thursdayDinnerMenuRepository)
        {
            _thursdayDinnerMenuRepository = thursdayDinnerMenuRepository;
        }

        [HttpGet]
        public IActionResult GetAllThursdayDinnerMenu()
        {
            if (_thursdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_thursdayDinnerMenuRepository.GetAll());
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{ItemId}")]
        public IActionResult GetItemById(int ItemId)
        {
            if (_thursdayDinnerMenuRepository.GetAll().Any())
            {
                return Ok(_thursdayDinnerMenuRepository.GetById(ItemId));
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult InsertThursdayDinnerItem(ThursdayDinnerMenu thursdayDinnerMenu)
        {
            var result = _thursdayDinnerMenuRepository.Create(thursdayDinnerMenu);
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
        public IActionResult UpdateThursdayDinnerMenu(int ItemId, ThursdayDinnerMenu thursdayDinnerMenu)
        {
            var result = _thursdayDinnerMenuRepository.Update(ItemId, thursdayDinnerMenu);
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
        public IActionResult DeleteThursdayDinnerItem(int ItemId)
        {
            var result = _thursdayDinnerMenuRepository.Delete(ItemId);
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
