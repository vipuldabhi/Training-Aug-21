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
    public class CancellationStatusController : ControllerBase
    {
        private readonly ICancellationStatusRepository _cancellationStatusRepository;
        private readonly IMapper _mapper;

        public CancellationStatusController(ICancellationStatusRepository cancellationStatusRepository, IMapper mapper)
        {
            _cancellationStatusRepository = cancellationStatusRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        public IActionResult GetAllData()
        {
            var result = _cancellationStatusRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var List = new List<CancellationStatusDto>();
                
                foreach (var i in result)
                {
                    List.Add(_mapper.Map<CancellationStatusDto>(i));
                }

                return Ok(List);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }


        /// <summary>  
        /// Get Data by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Data Details by Id Provided by User 
        /// </remarks> 

        [HttpGet("{Id}")]
        public IActionResult GetDataById(int Id)
        {
            //throw an Error if data is empty
            if (_cancellationStatusRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _cancellationStatusRepository.GetById(Id);
                if(data != null)
                {
                    return Ok(_mapper.Map<CancellationStatusDto>(data));
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

        [HttpPost]
        public IActionResult InsertData(CancellationStatus cancellationStatus)
        {
            if (cancellationStatus.Status == false)
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

        [HttpPut]
        public IActionResult UpdateData(CancellationStatus cancellationStatus)
        {
            if (cancellationStatus.Status == true)
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

        [HttpDelete("{id}")]
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
