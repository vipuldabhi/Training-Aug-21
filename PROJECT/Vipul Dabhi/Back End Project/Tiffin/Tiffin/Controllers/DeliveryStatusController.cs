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
        private readonly IIntervalRepository _intervalRepository;
        private readonly IMapper _mapper;

        public DeliveryStatusController(IDeliveryStatusRepository deliveryStatusRepository,IIntervalRepository intervalRepository, IMapper mapper)
        {
            _deliveryStatusRepository = deliveryStatusRepository;
            _intervalRepository = intervalRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All DeliveryStatus Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all DeliveryStatus Details Availabe in Database 
        /// </remarks> 

        //GET : api/deliverystatus
        [HttpGet]
        public IActionResult GetAllData()
        {
            var data = _deliveryStatusRepository.GetAll();
            var result = data.Where(a => a.IsDeleted == false);
            ///throw an Error if data is empty
            if (result.Any())
            {
                var DataList = new List<DeliveryStatusDto>();
                foreach (var i in result)
                {
                    var x = _mapper.Map<DeliveryStatusDto>(i);
                    var interval = _intervalRepository.GetAll();
                    var a = interval.FirstOrDefault(a => a.IntervalId == i.IntervalId);
                    x.IntervalName = a.IntervalName;
                    DataList.Add(x);
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

        //GET : api/deliverystatus/order/id
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

        //GET : api/deliverystatus/id
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
        /// Create Data
        /// </summary>   
        /// <param name="deliveryStatus"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new DeliveryStatus Data into the Database 
        /// </remarks> 

        //POST : api/deliverystatus
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

        //PUT : api/deliverystatus
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

        //DELETE : api/deliverystatus
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
