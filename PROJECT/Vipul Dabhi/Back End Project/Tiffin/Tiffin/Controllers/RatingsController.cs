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
    public class RatingsController : ControllerBase
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public RatingsController(IRatingRepository ratingRepository,IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _ratingRepository = ratingRepository;
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Ratings Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Ratings Details Availabe in Database 
        /// </remarks> 

        //GET : api/ratings
        [HttpGet]
        public IActionResult GetAllData()
        {
            var data = _ratingRepository.GetAll();
            var result = data.Where(a => a.IsDeleted == false);
            ///throw an Error if data is empty
            if (result.Any())
            {
                var DataList = new List<RatingDto>();
                foreach (var i in result)
                {
                    var x = _mapper.Map<RatingDto>(i);
                    var res = _restaurantRepository.GetAll();
                    var a = res.FirstOrDefault(a => a.Id == x.RestaurantId);
                    x.RestaurantName = a.RestaurantName;
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
        /// Get All Ratings Details According to Restaurant Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Ratings Details Of Perticular Restaurant
        /// </remarks> 

        //GET : api/ratings/restaurant/resid
        [HttpGet("restaurant/{id}")]

        public IActionResult GetRatingByRestaurantId(int resid)
        {
            var result = _ratingRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var DataList = new List<RatingDto>();
                var data = result.Where(a => a.RestaurantId == resid);
                foreach (var i in data)
                {
                    DataList.Add(_mapper.Map<RatingDto>(i));
                }

                return Ok(DataList);
            }
            else                                                             
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }



        /// <summary>  
        /// Get Ratings Details by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Ratings Detail by Id Provided by User 
        /// </remarks> 

        //GET : api/ratings/id
        [HttpGet("{Id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult GetRatingById(int Id)
        {
            //throw an Error if data is empty
            if (_ratingRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _ratingRepository.GetById(Id);
                if (data != null)
                {
                    return Ok(_mapper.Map<RatingDto>(data));
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
        /// <param name="rating"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Rating Data into the Database 
        /// </remarks> 

        //POST : api/ratings
        [HttpPost]
        public IActionResult InsertData(Rating rating)
        {
            ///try to Generate new Field If any Error occurs Return False
            var result = _ratingRepository.Create(rating);
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
        /// Update Ratings  
        /// </summary>  
        /// <param name="rating"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Ratings By Given Id into Data
        /// </remarks>  

        //PUT : api/ratings
        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateData(Rating rating)
        {
            var result = _ratingRepository.Update(rating);
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
        /// Delete Ratings Data
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Ratings By Given Id
        /// </remarks>  

        //DELETE : api/ratings
        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult DeleteData(int Id)
        {
            var result = _ratingRepository.Delete(Id);
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
