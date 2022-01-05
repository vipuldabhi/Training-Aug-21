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
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailRepository orderDetailRepository, IMapper mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Order Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Order Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAllOrderData()
        {
            var result = _orderDetailRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var OrderList = new List<OrderDetailDto>();
                    foreach (var i in data)
                    {
                        OrderList.Add(_mapper.Map<OrderDetailDto>(i));
                    }

                    return Ok(OrderList);
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
        /// Get OrderDetails by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Order Details by Id Provided by User 
        /// </remarks> 

        [HttpGet("{Id}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetOrderById(int Id)
        {
            //throw an Error if data is empty
            if (_orderDetailRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _orderDetailRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<OrderDetailDto>(data));
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
        /// Create Order
        /// </summary>   
        /// <param name="orderDetail"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Order into the Database 
        /// </remarks> 

        [HttpPost]
        [Authorize(Roles = "user,admin,deliveryboy")]
        public IActionResult InsertMenu(OrderDetail orderDetail)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (orderDetail.IsDeleted == false)
            {
                var result = _orderDetailRepository.Create(orderDetail);
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
        /// Update OrderDetails  
        /// </summary>  
        /// <param name="orderDetail"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update OrderDetails By Given Id into Data
        /// </remarks>  

        [HttpPut]
        [Authorize(Roles = "admin")]
        public IActionResult UpdateMenu(OrderDetail orderDetail)
        {
            if (orderDetail.IsDeleted == false)
            {
                var result = _orderDetailRepository.Update(orderDetail);
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
        /// Delete Order
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete OrderDetail By Given Id
        /// </remarks>  

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteMenu(int Id)
        {
            var result = _orderDetailRepository.Delete(Id);
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
