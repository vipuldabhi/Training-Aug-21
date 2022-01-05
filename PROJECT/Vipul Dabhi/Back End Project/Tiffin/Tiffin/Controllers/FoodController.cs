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
    public class FoodController : ControllerBase
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public FoodController(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Food Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Food Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        public IActionResult GetAllFoodsData()
        {
            var result = _foodRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var FoodList = new List<FoodDto>();
                    foreach (var i in data)
                    {
                        FoodList.Add(_mapper.Map<FoodDto>(i));
                    }

                    return Ok(FoodList);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }


        /// <summary>  
        /// Get Food by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Food Details by Id Provided by User 
        /// </remarks> 

        [HttpGet("{Id}")]
        public IActionResult GetFoodById(int Id)
        {
            //throw an Error if data is empty
            if (_foodRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _foodRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<AreaDto>(data));
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
        /// Create Food
        /// </summary>   
        /// <param name="food"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Food into the Database 
        /// </remarks> 

        [HttpPost]
        public IActionResult InsertData(Food food)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (food.IsDeleted == false)
            {
                var result = _foodRepository.Create(food);
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
        /// Update Food  
        /// </summary>  
        /// <param name="food"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Food By Given Id into Data
        /// </remarks>  

        [HttpPut]
        public IActionResult UpdateData(Food food)
        {
            if (food.IsDeleted == false)
            {
                var result = _foodRepository.Update(food);
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
        /// Delete Food
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Food By Given Id
        /// </remarks>  

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int Id)
        {
            var result = _foodRepository.Delete(Id);
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
