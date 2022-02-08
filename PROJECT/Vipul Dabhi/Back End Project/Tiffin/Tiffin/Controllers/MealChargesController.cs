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
    public class MealChargesController : ControllerBase
    {
        private readonly IMealChargesRepository _mealChargesRepository;
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IIntervalRepository _intervalRepository;

        public MealChargesController(IMealChargesRepository mealChargesRepository, IMapper mapper,IRestaurantRepository restaurantRepository,IIntervalRepository intervalRepository)
        {
            _mealChargesRepository = mealChargesRepository;
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _intervalRepository = intervalRepository;
        }


        /// <summary>  
        /// Get All MealCharges  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all MealCharges Details Availabe in Database 
        /// </remarks> 

        //GET : api/mealcharges
        [HttpGet]

        public IActionResult GetAllCharges()
        {
            var result = _mealChargesRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var ChargesList = new List<MealChargesDto>();
                    foreach (var i in data)
                    {
                        var x = _mapper.Map<MealChargesDto>(i);
                        var z = _restaurantRepository.GetById(x.RestaurantsId);
                        x.RestaurantName = z.RestaurantName;
                        var s = _intervalRepository.GetById(x.IntervalId);
                        x.IntervalName = s.IntervalName;
                        ChargesList.Add(x);
                    }

                    return Ok(ChargesList);
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
        /// Get Sorted Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// returns Sorted Data
        /// </remarks> 

        //GET : api/mealcharges/sorted/{sortid}/interval/id
        [HttpGet("sorted/{sortid}/interval/{id}")]
        public IActionResult GetAscSortedData(int sortid,int id)
        {
            var sortedData = _mealChargesRepository.GetSortedData(sortid,id);

            if(sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound("Data is Not Available!!!!");
            }
            
        }



        /// <summary>  
        /// Get Charges by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Charges Details by Id Provided by User 
        /// </remarks> 

        //GET : api/mealcharges/id
        [HttpGet("{Id}")]
        public IActionResult GetChargeById(int Id)
        {
            //throw an Error if data is empty
            if (_mealChargesRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _mealChargesRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<MealChargesDto>(data));
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


        //get MealCharge by restarantId and IntervalId

        /// <summary>  
        /// Get Charges by Given restarantId and IntervalId
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Charges Details by restarantId and IntervalId Provided by User 
        /// </remarks> 

        //GET : api/mealcharges/restaurantid/{resid}/intervalid/{intervalid}
        [HttpGet("restaurantid/{resId}/intervalid/{intervalid}")]
        public IActionResult GetChargeByResIdandIntervalId(int resId,int intervalid)
        {
            //throw an Error if data is empty
            if (_mealChargesRepository.GetAll().Any())
            {
                int result = _mealChargesRepository.getCharge(resId, intervalid);
                if (result != 0)
                {
                    return Ok(result);
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
        /// Create Charges
        /// </summary>   
        /// <param name="mealCharges"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Charges into the Database 
        /// </remarks> 

        //POST : api/mealcharges
        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult InsertData(MealCharge mealCharges)
        {
            ///try to Generate new Field If any Error occurs Return False
            if (mealCharges.IsDeleted == false)
            {
                var result = _mealChargesRepository.Create(mealCharges);
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
        /// Update Charges  
        /// </summary>  
        /// <param name="mealCharges"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update charges By Given Id 
        /// </remarks>  

        //PUT : api/mealcharges
        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateData([FromBody] MealCharge mealCharges)
        {
            if (mealCharges.IsDeleted == false)
            {
                var result = _mealChargesRepository.Update(mealCharges);
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
        /// Delete Charges
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Charges By Given Id
        /// </remarks>  

        //DELETE : api/mealcharges/id
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int Id)
        {
            var result = _mealChargesRepository.Delete(Id);
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
