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
    [Authorize(Roles = "admin,deliveryboy")]
    public class DeliveryStatusController : ControllerBase
    {
        private readonly IDeliveryStatusRepository _deliveryStatusRepository;
        private readonly IMapper _mapper;

        public DeliveryStatusController(IDeliveryStatusRepository deliveryStatusRepository, IMapper mapper)
        {
            _deliveryStatusRepository = deliveryStatusRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All DeliveryStatus Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all DeliveryStatus Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        public IActionResult GetAllData()
        {
            var result = _deliveryStatusRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                    var DataList = new List<DeliveryStatusDto>();
                    foreach (var i in result)
                    {
                        DataList.Add(_mapper.Map<DeliveryStatusDto>(i));
                    }

                    return Ok(DataList);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }




        /// <summary>  
        /// Get All DeliveryStatus Details According to Order Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all DeliveryStatus Details Of Perticular Order
        /// </remarks> 

        [HttpGet("order/{id}")]
        public IActionResult GetDeliveryStatusByOrderId(int id)
        {
            var result = _deliveryStatusRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var DataList = new List<DeliveryStatusDto>();
                var data = result.Where(a => a.OrderId == id);
                foreach (var i in data)
                {
                    DataList.Add(_mapper.Map<DeliveryStatusDto>(i));
                }

                return Ok(DataList);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }



        /// <summary>  
        /// Get DeliveryStatus Details by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get DeliveryStatus Detail by Id Provided by User 
        /// </remarks> 

        [HttpGet("{Id}")]
        public IActionResult GetAreaById(int Id)
        {
            //throw an Error if data is empty
            if (_deliveryStatusRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _deliveryStatusRepository.GetById(Id);
                if (data != null)
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
        /// Create Data
        /// </summary>   
        /// <param name="deliveryStatus"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new DeliveryStatus Data into the Database 
        /// </remarks> 

        [HttpPost]
        public IActionResult InsertData(DeliveryStatus deliveryStatus)
        {
            ///try to Generate new Field If any Error occurs Return False
            var result = _deliveryStatusRepository.Create(deliveryStatus);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }


        /// <summary>  
        /// Update DeliveryStatus  
        /// </summary>  
        /// <param name="deliveryStatus"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update DeliveryStatus By Given Id into Data
        /// </remarks>  

        [HttpPut]
        public IActionResult UpdateData(DeliveryStatus deliveryStatus)
        {
            var result = _deliveryStatusRepository.Update(deliveryStatus);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }


        /// <summary>  
        /// Delete DeliveryStatus Data
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete DeliveryStatus By Given Id
        /// </remarks>  

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int Id)
        {
            var result = _deliveryStatusRepository.Delete(Id);
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
