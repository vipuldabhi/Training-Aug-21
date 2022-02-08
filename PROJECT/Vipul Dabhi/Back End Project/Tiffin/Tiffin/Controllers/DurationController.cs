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
    public class DurationController : ControllerBase
    {
        private readonly IDurationRepository _durationRepository;
        private readonly IMapper _mapper;

        public DurationController(IDurationRepository durationRepository, IMapper mapper)
        {
            _durationRepository = durationRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Order Duration Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Order Duration Details Availabe in Database 
        /// </remarks> 

        //GET : api/duration
        [HttpGet]
        public IActionResult GetAllDurations()
        {
            var result = _durationRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var DurationList = new List<DurationDto>();
                    foreach (var i in data)
                    {
                        DurationList.Add(_mapper.Map<DurationDto>(i));
                    }

                    return Ok(DurationList);
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
        /// Get Duration by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Duration Details by Id Provided by User 
        /// </remarks> 

        //GET : api/duration/id
        [HttpGet("{Id}")]

        public IActionResult GetDurationById(int Id)
        {
            //throw an Error if data is empty
            if (_durationRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _durationRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(data);
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
        /// Create Duration
        /// </summary>   
        /// <param name="duration"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Duration into the Database 
        /// </remarks> 

        //POST : api/duration
        [HttpPost]
        [Authorize(Roles = "admin")]

        public IActionResult InsertData(Duration duration)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (duration.IsDeleted == false)
            {
                var result = _durationRepository.Create(duration);
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
        /// Update Duration  
        /// </summary>  
        /// <param name="duration"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Duration By Given Id into Data
        /// </remarks>  

        //PUT : api/duration
        [HttpPut]
        [Authorize(Roles = "admin")]

        public IActionResult UpdateData(Duration duration)
        {
            if (duration.IsDeleted == false)
            {
                var result = _durationRepository.Update(duration);
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
        /// Delete Duration
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Duration By Given Id
        /// </remarks>  

        //DELETE : api/duration
        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]

        public IActionResult DeleteData(int Id)
        {
            var result = _durationRepository.Delete(Id);
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
