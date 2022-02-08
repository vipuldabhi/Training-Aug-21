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
    
    public class CancellationStatusController : ControllerBase
    {
        private readonly ICancellationStatusRepository _cancellationStatusRepository;
        private readonly IIntervalRepository _intervalRepository;
        private readonly IMapper _mapper;

        public CancellationStatusController(ICancellationStatusRepository cancellationStatusRepository,IIntervalRepository intervalRepository, IMapper mapper)
        {
            _cancellationStatusRepository = cancellationStatusRepository;
            _intervalRepository = intervalRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Details Availabe in Database 
        /// </remarks>          

        //GET : api/cancellationstatus
        [HttpGet]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult GetAllData()
        {
            var result = _cancellationStatusRepository.GetAll();
            var data = result.Where(a => a.IsDeleted == false);
            ///throw an Error if data is empty
            if (data.Any())
            {
                var List = new List<CancellationStatusDto>();
                var interval = _intervalRepository.GetAll();
                foreach (var i in data)
                {
                    var x = _mapper.Map<CancellationStatusDto>(i);
                    var z = interval.FirstOrDefault(a => a.IntervalId == x.IntervalId);
                    x.IntervalName = z.IntervalName;
                    List.Add(x);
                }

                return Ok(List);
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
        /// return sorted based on cancellationDate
        /// </remarks> 

        //GET : api/cancellationstatus/sorted/sortid
        [HttpGet("sorted/{sortid}")]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult GetAscSortedArea(int sortid)
        {
            var sortedData = _cancellationStatusRepository.GetSortedData(sortid);
            if(sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound();
            }

        }



        /// <summary>  
        /// Get Data by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Data Details by Id Provided by User 
        /// </remarks> 

        //GET : api/cancellationstatus/id
        [HttpGet("{Id}")]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult GetDataById(int Id)
        {
            //throw an Error if data is empty
            if (_cancellationStatusRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _cancellationStatusRepository.GetById(Id);
                var interval = _intervalRepository.GetAll();

                if (data != null)
                {
                    var x = _mapper.Map<CancellationStatusDto>(data);
                    var z = interval.FirstOrDefault(a => a.IntervalId == x.IntervalId);
                    x.IntervalName = z.IntervalName;
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
        /// Create Cancellation Data
        /// </summary>   
        /// <param name="cancellationStatus"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new Cancellation Data into the Database 
        /// </remarks> 

        //POST : api/cancellationstatus
        [HttpPost]
        [Authorize(Roles = "admin,user,deliveryboy")]
        public IActionResult InsertData(CancellationStatus cancellationStatus)
        {
            if (cancellationStatus.Status == true && cancellationStatus.IsDeleted == false)
            {
                ///try to Generate new Field If any Error occurs Return False
                var result = _cancellationStatusRepository.Create(cancellationStatus);
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
        /// Update Cancellation Data  
        /// </summary>  
        /// <param name="cancellationStatus"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update Cancellation Data By Given Id 
        /// </remarks>  

        //PUT : api/cancellationstatus
        [HttpPut]
        [Authorize(Roles = "admin,user,deliveryboy")]
        public IActionResult UpdateData(CancellationStatus cancellationStatus)
        {
            if (cancellationStatus.Status == true && cancellationStatus.IsDeleted == false)
            {
                var result = _cancellationStatusRepository.Update(cancellationStatus);
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
        /// Delete Cancellation Data
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete Cancellation Data By Given Id
        /// </remarks>  

        //DELETE : api/cancellationstatus/id
        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteData(int Id)
        {           
            var result = _cancellationStatusRepository.Delete(Id);
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
