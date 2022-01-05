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
    [Authorize(Roles = UserRoles.Admin)]
    public class AreaController : ControllerBase
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public AreaController(IAreaRepository areaRepository,IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Areas  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Areas Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        public IActionResult GetAllAreas()
        {
            var result = _areaRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var AreaList = new List<AreaDto>();
                    foreach(var i in data)
                    {
                        AreaList.Add(_mapper.Map<AreaDto>(i));
                    }

                    return Ok(AreaList);
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
        /// Get Area by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Area Details by Id Provided by User 
        /// </remarks> 
         
        [HttpGet("{Id}")]
        public IActionResult GetAreaById(int Id)
        {
            //throw an Error if data is empty
            if (_areaRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _areaRepository.GetById(Id);
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
        /// Create Area
        /// </summary>   
        /// <param name="area"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Area into the Database 
        /// </remarks> 

        [HttpPost]
        public IActionResult InsertData(Area area)
        {
            ///try to Generate new Field If any Error occurs Return False
            if(area.IsDeleted == false)
            {
                var result = _areaRepository.Create(area);
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
        /// Update Area  
        /// </summary>  
        /// <param name="area"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Area By Given Id 
        /// </remarks>  

        [HttpPut]
        public IActionResult UpdateData(Area area)
        {
            if(area.IsDeleted == false)
            {
                var result = _areaRepository.Update(area);
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
        /// Delete Area
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Area By Given Id
        /// </remarks>  

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int Id)
        {
            var result = _areaRepository.Delete(Id);
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


