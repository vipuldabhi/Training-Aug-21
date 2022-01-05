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
    public class DayWiseMenuController : ControllerBase
    {
        private readonly IDayWiseMenuRepository _dayWiseMenuRepository;
        private readonly IMapper _mapper;

        public DayWiseMenuController(IDayWiseMenuRepository dayWiseMenuRepository, IMapper mapper)
        {
            _dayWiseMenuRepository = dayWiseMenuRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Menu Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Menu Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAllData()
        {
            var result = _dayWiseMenuRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                    var MenuList = new List<DayWiseMenuDto>();
                    foreach (var i in result)
                    {
                        MenuList.Add(_mapper.Map<DayWiseMenuDto>(i));
                    }

                    return Ok(MenuList);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }


        /// <summary>  
        /// Get Day Wise Menu By Day Id
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Day Wise Menu Details By Proveded Day Id
        /// </remarks> 

        [HttpGet("daywise/{id}")]
        [Authorize(Roles = "user,admin,deliveryboy")]
        public IActionResult GetMenuByDayId(int id)
        {
            var result = _dayWiseMenuRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.DayId == id);
                if (data.Any())
                {
                    var MenuList = new List<DayWiseMenuDto>();
                    foreach (var i in data)   
                    {
                        MenuList.Add(_mapper.Map<DayWiseMenuDto>(i));
                    }

                    return Ok(MenuList);
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


    }
}
