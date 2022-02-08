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
    public class DeliveryChargesController : ControllerBase
    {
        private readonly IDeliveryChargesRepository _deliveryChargesRepository;
        private readonly IDurationRepository _durationRepository;
        private readonly IMapper _mapper;

        public DeliveryChargesController(IDeliveryChargesRepository deliveryChargesRepository,IDurationRepository durationRepository, IMapper mapper)
        {
            _deliveryChargesRepository = deliveryChargesRepository;
            _durationRepository = durationRepository;
            _mapper = mapper;
        }



        /// <summary>  
        /// Get All DeliveryCharges  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all DeliveryCharges Details Availabe in Database 
        /// </remarks> 

        //GET : api/deliverycharges
        [HttpGet]
        public IActionResult GetAllData()
        {
            var result = _deliveryChargesRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var List = new List<DeliveryChargesDto>();
                    foreach (var i in data)
                    {
                        var x = _mapper.Map<DeliveryChargesDto>(i);
                        var duration = _durationRepository.GetById(i.DurationId);
                        x.DurationTime = duration.DurationTime;
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




        /// <summary>  
        /// Get DeliveryCharge by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get DeliveryCharge Details by Id Provided by User 
        /// </remarks> 

        //GET : api/deliverycharges/id
        [HttpGet("{Id}")]

        public IActionResult GetDataById(int Id)
        {
            //throw an Error if data is empty
            if (_deliveryChargesRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _deliveryChargesRepository.GetById(Id);
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
        /// Create DeliveryChrge
        /// </summary>   
        /// <param name="deliveryCharge"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new DeliveryChrge into the Database 
        /// </remarks> 

        //POST : api/deliverycharge
        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult InsertData(DeliveryCharge deliveryCharge)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (deliveryCharge.IsDeleted == false)
            {
                var result = _deliveryChargesRepository.Create(deliveryCharge);
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
        /// Update DeliveryChrge  
        /// </summary>  
        /// <param name="deliveryCharge"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update DeliveryChrge By Given Id 
        /// </remarks>  

        //PUT : api/deliverycharges
        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateData( DeliveryCharge deliveryCharge)
        {
            if (deliveryCharge.IsDeleted == false)
            {
                var result = _deliveryChargesRepository.Update(deliveryCharge);
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
        /// Delete DeliveryChrge
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete DeliveryChrge By Given Id
        /// </remarks>  

        //DELETE : api/deliverycharges/id
        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult DeleteData(int Id)
        {
            var result = _deliveryChargesRepository.Delete(Id);
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
