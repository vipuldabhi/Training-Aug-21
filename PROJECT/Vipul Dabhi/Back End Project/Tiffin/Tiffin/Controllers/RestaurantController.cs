using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Entities;
using Tiffin.Models;
using Tiffin.Repository;

namespace Tiffin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public RestaurantController(IRestaurantRepository restaurantRepository,IAreaRepository areaRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _areaRepository = areaRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Restaurant  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Restaurant Details Availabe in Database 
        /// </remarks> 

        //GET : api/restaurant
        [HttpGet]
        public IActionResult GetAllRestaurants()
        {
            var result = _restaurantRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var RestaurantList = new List<RestaurantsDto>();
                    foreach (var i in data)
                    {
                        var x = _mapper.Map<RestaurantsDto>(i);
                        var z = _areaRepository.GetById(i.AreaId);
                        x.AreaName = z.AreaName;
                        RestaurantList.Add(x);
                    }

                    return Ok(RestaurantList);
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

        //Get Sorted Data


        /// <summary>  
        /// Get Sorted Restaurant  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// return sorted data as per Restaurant name 
        /// </remarks> 

        //GET : api/restaurant/sorted/sortid        ///1 for ascending and 0 for descending
        [HttpGet("sorted/{sortid}")]
        public IActionResult GetSortedRestaurant(int sortid)
        {
            var sortedData = _restaurantRepository.GetSortedData(sortid);
            if (sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound("Data is not Available in Database!!!!");
            }

        }

        /// <summary>  
        /// Get Restaurant by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Restaurant Details by Id Provided by User 
        /// </remarks> 

        //GET : api/restaurant/id
        [HttpGet("{Id}")]
        public IActionResult GetRestaurantById(int Id)
        {
            //throw an Error if data is empty
            if (_restaurantRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _restaurantRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<RestaurantsDto>(data));
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
        /// Create Restaurant
        /// </summary>   
        /// <param name="restaurants"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Restaurant into the Database 
        /// </remarks> 

        //POST : api/restaurant
        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult InsertData([FromBody] Restaurant restaurants)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (restaurants.IsDeleted == false)
            {
                var result = _restaurantRepository.Create(restaurants);
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
        /// Update Restaurant  
        /// </summary>  
        /// <param name="restaurants"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Restaurant By Given Id 
        /// </remarks>  

        //PUT : api/restaurants
        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult UpdateData([FromBody] Restaurant restaurants)
        {
            if (restaurants.IsDeleted == false)
            {
                var result = _restaurantRepository.Update(restaurants);
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
        /// Delete Restaurants
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Restaurants By Given Id
        /// </remarks>  

        //DELETE : api/restaurants/id
        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteData(int Id)
        {
            var result = _restaurantRepository.Delete(Id);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
