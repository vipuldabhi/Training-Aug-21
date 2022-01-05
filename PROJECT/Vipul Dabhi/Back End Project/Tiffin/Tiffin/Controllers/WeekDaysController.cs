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
    public class WeekDaysController : ControllerBase
    {
        private readonly IWeekDayRepository _weekDayRepository;
        private readonly IMapper _mapper;

        public WeekDaysController(IWeekDayRepository weekDayRepository, IMapper mapper)
        {
            _weekDayRepository = weekDayRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All WeekDays Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all WeekDays Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        public IActionResult GetAllWeekDaysData()
        {
            var result = _weekDayRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var WeekDaysList = new List<WeekDayDto>();
                    foreach (var i in data)
                    {
                        WeekDaysList.Add(_mapper.Map<WeekDayDto>(i));
                    }

                    return Ok(WeekDaysList);
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
        /// Get WeekDay by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get WeekDays Details by Id Provided by User 
        /// </remarks> 

        [HttpGet("{Id}")]
        public IActionResult GetWeekDayById(int Id)
        {
            //throw an Error if data is empty
            if (_weekDayRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _weekDayRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<WeekDayDto>(data));
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
        /// Create WeekDay
        /// </summary>   
        /// <param name="weekDay"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new WeekDay into the Database 
        /// </remarks> 

        [HttpPost]
        public IActionResult InsertWeekDay(WeekDay weekDay)
        {
            if (weekDay.IsDeleted == false)
            {
                ///try to Generate new Field If any Error occurs Return False
                var result = _weekDayRepository.Create(weekDay);
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
        /// Update WeekDay  
        /// </summary>  
        /// <param name="weekDay"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update WeekDay By Given Id into Data
        /// </remarks>  

        [HttpPut]
        public IActionResult UpdateWeekDay(WeekDay weekDay)
        {
            if (weekDay.IsDeleted == false)
            {
                var result = _weekDayRepository.Update(weekDay);
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
        /// Delete WeekDay
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete WeekDay By Given Id
        /// </remarks>  

        [HttpDelete("{id}")]
        public IActionResult DeleteWeekDay(int Id)
        {
            var result = _weekDayRepository.Delete(Id);
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
