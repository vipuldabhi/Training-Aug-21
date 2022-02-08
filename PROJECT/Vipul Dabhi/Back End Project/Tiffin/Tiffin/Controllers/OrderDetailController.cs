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
        private readonly ITotalRevenueRepository _totalRevenueRepository;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailRepository orderDetailRepository,ITotalRevenueRepository totalRevenueRepository, IMapper mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _totalRevenueRepository = totalRevenueRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Order Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Order Details Availabe in Database 
        /// </remarks> 

        //GET : api/orderdetail
        [HttpGet]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult GetAllOrderData()
        {
            var result = _orderDetailRepository.GetAllOrders();
            ///throw an Error if data is empty
            if (result.Any())
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }



        //Get Sorted Data


        /// <summary>  
        /// Get Sorted Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// return sorted based on OrderDate
        /// </remarks> 

        ///GET : api/orderdetail/sorted/sortid/refid   //refid 3 for based on orderdate and 4 for orderplacedate
        [HttpGet("sorted/{sortid}/{refid}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetSortedArea(int sortid,int refid)
        {
            var sortedData = _orderDetailRepository.GetSortedData(sortid,refid);
            if (sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound();
            }

        }



        //#######    Get Total Revenue From Order    ###############

        /// <summary>  
        /// Get Total Revenue From All Orders
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// returns Total Revenue From All Orders
        /// </remarks> 

        //GET : api/orderdetail/totalrevenue
        [HttpGet("totalrevenue")]
        [Authorize(Roles = "admin")]
        public IActionResult GetTotalRevenue()
        {
            //throw an Error if data is empty
            if (_totalRevenueRepository.GetAll().Any())
            {
                return Ok(_totalRevenueRepository.GetAll());
            }
            else
            {
                return NotFound("Record Not Found!!!");
            }
        }




        //#######    Get Order Of a Perticular Month    ###############


        /// <summary>  
        /// Get Orders of Given Month
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// returns Orders Details of Given Month
        /// </remarks> 

        //GET : api/orderdetail/month/{month}/year/{year}
        [HttpGet("month/{month}/year/{year}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetOrderByMonthandYear(int month,int year)
        {
            var result = _orderDetailRepository.GetOrderOfTheMonth(month, year);

            //throw an Error if data is empty
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Record Not Found!!!");
            }
        }


        //#######    Get Order Between Given Date    ###############


        /// <summary>  
        /// Get Orders Between Given Date
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// returns Orders Details Between Given Date
        /// </remarks> 

        //GET : api/orderdetail/startdate/{startdate}/enddate/{enddate}
        [HttpGet("startdate/{startdate}/enddate/{enddate}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetOrderBetweenGivenDate(DateTime startdate, DateTime enddate)
        {
            var result = _orderDetailRepository.GetOrderBetweenGivenDate(startdate, enddate);

            //throw an Error if data is empty
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Record Not Found!!!");
            }
        }


        //#######    Get Total Revenue From Order Between Given Date    ###############


        /// <summary>  
        /// Get total revenue of Orders Between Given Date
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// return total revenue of Orders Details Between Given Date
        /// </remarks> 

        //GET : api/orderdetail/revenue/startdate/{startdate}/enddate/{enddate}
        [HttpGet("revenue/startdate/{startdate}/enddate/{enddate}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetTotalRevenueFromOrderBetweenGivenDate(DateTime startdate, DateTime enddate)
        {
            var result = _orderDetailRepository.GetTotalRevenueFromOrderBetweenGivenDate(startdate, enddate);

            //throw an Error if data is empty
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Record Not Found!!!");
            }
        }



        /// <summary>  
        /// Get OrderDetails by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Order Details by Id Provided by User 
        /// </remarks> 

        //GET : api/orderdetail/id
        [HttpGet("{Id}")]
        [Authorize(Roles = "admin,user,deliveryboy")]
        public IActionResult GetOrderById(int Id)
        {
            var result = _orderDetailRepository.GetOrderById(Id);
            ///throw an Error if data is empty
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }


        //Get order by user id

        /// <summary>  
        /// Get OrderDetails by Given User Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Order Details by User Id Provided by User 
        /// </remarks> 

        //GET : api/orderdetail/userid/id
        [HttpGet("userid/{Id}")]
        [Authorize(Roles = "admin,user")]
        public IActionResult GetOrderByUserId(int Id)
        {
            var result = _orderDetailRepository.GetOrderByUserId(Id);
            ///throw an Error if data is empty
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
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

        //POST : api/orderdetail
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

        //PUT : api/orderdetail
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

        //DELETE : api/orderdetail/id
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
