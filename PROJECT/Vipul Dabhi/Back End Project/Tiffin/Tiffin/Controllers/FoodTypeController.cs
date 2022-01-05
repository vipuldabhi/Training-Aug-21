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
    public class FoodTypeController : ControllerBase
    {
        private readonly IFoodTypeRepository _foodTypeRepository;
        private readonly IMapper _mapper;

        public FoodTypeController(IFoodTypeRepository foodTypeRepository, IMapper mapper)
        {
            _foodTypeRepository = foodTypeRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All FoodType Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all FoodType Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        public IActionResult GetAllFoodTypeData()
        {
            var result = _foodTypeRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var FoodTypeList = new List<FoodTypeDto>();
                    foreach (var i in data)
                    {
                        FoodTypeList.Add(_mapper.Map<FoodTypeDto>(i));
                    }

                    return Ok(FoodTypeList);
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
        /// Get FoodType by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get FoodType Details by Id Provided by User 
        /// </remarks> 

        [HttpGet("{Id}")]
        public IActionResult GetFoodTypeById(int Id)
        {
            //throw an Error if data is empty
            if (_foodTypeRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _foodTypeRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<FoodTypeDto>(data));
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
        /// Create FoodType
        /// </summary>   
        /// <param name="foodType"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new FoodType into the Database 
        /// </remarks> 

        [HttpPost]
        public IActionResult InsertFoodType(FoodType foodType)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (foodType.IsDeleted == false)
            {
                var result = _foodTypeRepository.Create(foodType);
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
        /// Update FoodType  
        /// </summary>  
        /// <param name="foodType"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update FoodType By Given Id into Data
        /// </remarks>  

        [HttpPut]
        public IActionResult UpdateFoodType(FoodType foodType)
        {
            if (foodType.IsDeleted == false)
            {
                var result = _foodTypeRepository.Update(foodType);
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
        /// Delete FoodType
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete FoodType By Given Id
        /// </remarks>  

        [HttpDelete("{id}")]
        public IActionResult DeleteFoodType(int Id)
        {
            var result = _foodTypeRepository.Delete(Id);
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
