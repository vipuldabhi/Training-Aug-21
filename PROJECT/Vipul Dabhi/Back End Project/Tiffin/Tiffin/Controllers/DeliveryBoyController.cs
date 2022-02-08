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
    public class DeliveryBoyController : ControllerBase
    {
         private readonly IDeliveryBoyRepository _deliveryBoyRepository;
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public DeliveryBoyController(IDeliveryBoyRepository deliveryBoyRepository,IAreaRepository areaRepository, IMapper mapper)
        {
            _deliveryBoyRepository = deliveryBoyRepository;
            _areaRepository = areaRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All DeliveryBoy Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all DeliveryBoy Details Availabe in Database 
        /// </remarks> 

        //GET : api/deliveryboy
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAllData()
        {
            var result = _deliveryBoyRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var List = new List<DeliveryBoyDto>();
                    var area = _areaRepository.GetAll();
                    foreach (var i in data)
                    {
                        var x = _mapper.Map<DeliveryBoyDto>(i);
                        var Area = area.FirstOrDefault(a => a.AreaId == i.AssignedAreaId);
                        x.AreaName = Area.AreaName;
                        List.Add(x);
                    }

                    return Ok(List);
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
        /// Get  Sorted Data
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// return sorted 
        /// </remarks> 

        //GET : api/deliveryboy/sorted/sortid/refid
        [HttpGet("sorted/{sortid}/{refid}")]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult GetAscSortedData(int sortid,int refid)
        {
            var sortedData = _deliveryBoyRepository.GetSortedData(sortid,refid);
            if (sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound();
            }

        }



        /// <summary>  
        /// Get DeliveryBoy Details by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get DeliveryBoy Details by Id Provided by User 
        /// </remarks> 

        //GET : api/deliveryboy/id
        [HttpGet("{Id}")]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult GetDeliveryBoyById(int Id)
        {
            //throw an Error if data is empty
            if (_deliveryBoyRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _deliveryBoyRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    var x = _mapper.Map<DeliveryBoyDto>(data);
                    var area = _areaRepository.GetById(x.AssignedAreaId);
                    x.AreaName = area.AreaName;
                    return Ok(x);
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
        /// Create DeliveryBoy
        /// </summary>  
        /// <param name="deliveryBoy"></param>
        /// <returns></returns>
        /// <remarks>
        /// Create new DeliveryBoy into the Database
        /// </remarks>    

        //POST : api/deliveryboy
        [HttpPost]
        public IActionResult InsertData(DeliveryBoy deliveryBoy)
        {
            if (deliveryBoy.IsDeleted == false)
            {
                ///try to Generate new Field If any Error occurs Return False
                var result = _deliveryBoyRepository.Create(deliveryBoy);
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
        /// Update DeliveryBoy Detail  
        /// </summary>  
        /// <param name="deliveryBoy"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update DeliveryBoy Detail By Given Id into Data
        /// </remarks>  

        //PUT : api/deliveryboy
        [HttpPut]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult UpdateData(DeliveryBoy deliveryBoy)
        {
            if (deliveryBoy.IsDeleted == false)
            {
                var result = _deliveryBoyRepository.Update(deliveryBoy);
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
        /// Delete DeliveryBoy
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete DeliveryBoy By Given Id
        /// </remarks>  

        //DELETE : api/deliveryboy/id
        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteData(int Id)
        {
            var result = _deliveryBoyRepository.Delete(Id);
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
