using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;
using Tiffin.Repository;

namespace Tiffin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public MenuController(IMenuRepository menuRepository,IFoodRepository foodRepository,IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _foodRepository = foodRepository;
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Menu Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Menu Details Availabe in Database 
        /// </remarks> 

        //GET : api/menu
        [HttpGet]
        public IActionResult GetAllMenuData()
        {
            var result = _menuRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var MenuList = new List<MenuDto>();
                    foreach (var i in data)
                    {
                        var a = _foodRepository.GetById(i.FoodId);
                        var b = _restaurantRepository.GetById(i.RestaurantsId);
                        var x = _mapper.Map<MenuDto>(i);
                        x.FoodName = a.FoodName;
                        x.RestaurantName = b.RestaurantName;
                        MenuList.Add(x);
                    }

                    return Ok(MenuList);
                }
                else
                {
                    return NotFound("Data Not Available In Database!!!");
                }
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }


        /// <summary>  
        /// Get Menu by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Menu Details by Id Provided by User 
        /// </remarks> 

        //GET : api/menu/id
        [HttpGet("{Id}")]
        public IActionResult GetMenuById(int Id)
        {
            //throw an Error if data is empty
            if (_menuRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _menuRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<MenuDto>(data));
                }
                else
                {
                    return NotFound("Record Not Found!!!");
                }
            }
            else
            {
                return NotFound("Record Not Found!!!");
            }
        }


        /// <summary>  
        /// Create Menu
        /// </summary>   
        /// <param name="menu"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Menu into the Database 
        /// </remarks> 

        //POST : api/menu
        [HttpPost]
        public IActionResult InsertMenu(Menu menu)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (menu.IsDeleted == false)
            {
                var result = _menuRepository.Create(menu);
                if (result == true)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }

        }


        /// <summary>  
        /// Update Menu  
        /// </summary>  
        /// <param name="menu"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Menu By Given Id into Data
        /// </remarks>  

        //PUT : api/menu
        [HttpPut]
        public IActionResult UpdateMenu(Menu menu)
        {
            if (menu.IsDeleted == false)
            {
                var result = _menuRepository.Update(menu);
                if (result == true)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }


        /// <summary>  
        /// Delete Menu
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete MenuType By Given Id
        /// </remarks>  

        //DELETE : api/menu/id
        [HttpDelete("{id}")]
        public IActionResult DeleteMenu(int Id)
        {
            var result = _menuRepository.Delete(Id);
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
