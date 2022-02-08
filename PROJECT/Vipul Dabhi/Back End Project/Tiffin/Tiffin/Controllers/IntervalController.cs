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
    public class IntervalController : ControllerBase
    {
        private readonly IIntervalRepository _intervalRepository;
        private readonly IMapper _mapper;

        public IntervalController(IIntervalRepository intervalRepository, IMapper mapper)
        {
            _intervalRepository = intervalRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Interval  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Interval Details Availabe in Database 
        /// </remarks> 

        //GET : api/interval
        [HttpGet]
        public IActionResult GetAllInterval()
        {
            var result = _intervalRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var IntervalList = new List<IntervalDto>();
                    foreach (var i in data)
                    {
                        IntervalList.Add(_mapper.Map<IntervalDto>(i));
                    }

                    return Ok(IntervalList);
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
        /// Get Interval by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Interval Details by Id Provided by User 
        /// </remarks> 

        //GET : api/interval/id
        [HttpGet("{Id}")]

        public IActionResult GetIntervalById(int Id)
        {
            //throw an Error if data is empty
            if (_intervalRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _intervalRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<IntervalDto>(data));
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
        /// Create Interval
        /// </summary>   
        /// <param name="interval"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Interval into the Database 
        /// </remarks> 

        //POST : api/interval
        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult InsertData([FromBody] Interval interval)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (interval.IsDeleted == false)
            {
                var result = _intervalRepository.Create(interval);
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
        /// Update Interval  
        /// </summary>  
        /// <param name="interval"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Interval By Given Id 
        /// </remarks>  

        //PUT : api/interval
        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateData([FromBody] Interval interval)
        {
            if (interval.IsDeleted == false)
            {
                var result = _intervalRepository.Update(interval);
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
        /// Delete Interval
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Interval By Given Id
        /// </remarks>  

        //DELETE : api/interval/id
        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult DeleteData(int Id)
        {
            var result = _intervalRepository.Delete(Id);
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
