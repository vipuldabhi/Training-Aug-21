using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Repository;

namespace Tiffin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvgRatingController : ControllerBase
    {
        private readonly IAvgRatingRepository _avgRatingRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public AvgRatingController(IAvgRatingRepository avgRatingRepository,
                                   IRestaurantRepository restaurantRepository,
                                   IAreaRepository areaRepository,
                                   IMapper mapper)
        {
            _avgRatingRepository = avgRatingRepository;
            _restaurantRepository = restaurantRepository;
            _areaRepository = areaRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Ratings Details Availabe in Database 
        /// </remarks> 

        //GET : api/avgrating
        [HttpGet]
        public IActionResult GetAllData()
        {
            var result = _avgRatingRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var List = new List<AvgRatingDto>();
                foreach(var i in result)
                {
                    var x = _mapper.Map<AvgRatingDto>(i);
                    var z = _restaurantRepository.GetById(i.RestaurantId);
                    var a = _areaRepository.GetById(z.AreaId);
                    x.RestaurantName = z.RestaurantName;
                    x.AreaName = a.AreaName;
                    List.Add(x);
                }
                    return Ok(List);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }


        /// <summary>  
        /// Get Rating by RestaurantId
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Rating Details By Proveded Restaurant Id
        /// </remarks> 

        //GET : api/avgrating/restaurant/{id}
        [HttpGet("restaurant/{id}")]
        public IActionResult GetRatingById(int id)
        {
            var result = _avgRatingRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.RestaurantId == id);
                if (data.Any())
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound("Requried Data Is Not Available!!!");
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
        /// return sorted data as per restaurant rating 
        /// </remarks> 

        //GET : api/avgrating/sorted/sortid        ///1 for ascending and 0 for descending
        [HttpGet("sorted/{sortid}")]
        public IActionResult GetSortedData(int sortid)
        {
            var sortedData = _avgRatingRepository.GetSortedData(sortid);
            if (sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound("Data is not Available in Database!!!!");
            }

        }

    }
}
