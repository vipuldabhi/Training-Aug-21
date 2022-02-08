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

        //GET : api/area
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


        
        //Get Sorted Data


        /// <summary>  
        /// Get Sorted Areas  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// return sorted data as per area name 
        /// </remarks> 

        //GET : api/area/sorted/sortid        ///1 for ascending and 0 for descending
        [HttpGet("sorted/{sortid}")]
        public IActionResult GetSortedArea(int sortid)
        {
            var sortedData = _areaRepository.GetSortedData(sortid);
            if(sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound("Data is not Available in Database!!!!");
            }

        }



        /// <summary>  
        /// Get Area by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Area Details by Id Provided by User 
        /// </remarks> 

        //GET : api/area/id
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
        /// Create Area
        /// </summary>   
        /// <param name="area"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Area into the Database 
        /// </remarks> 

        //POST : api/area
        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

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

        //PUT : api/area
        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateData([FromBody]Area area)
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

        //DELETE : api/area/id
        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult DeleteData(int Id)
        {
            var result = _areaRepository.Delete(Id);
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


