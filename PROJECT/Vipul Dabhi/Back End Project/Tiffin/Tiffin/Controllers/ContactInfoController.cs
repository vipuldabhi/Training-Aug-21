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
    [Authorize(Roles = "admin")]
    public class ContactInfoController : ControllerBase
    {
        private readonly IContactInfoRepository _contactInfoRepository;
        private readonly IMapper _mapper;

        public ContactInfoController(IContactInfoRepository contactInfoRepository, IMapper mapper)
        {
            _contactInfoRepository = contactInfoRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All ContactInfo Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all ContactInfo Details Availabe in Database 
        /// </remarks> 

        //GET : api/contactinfo
        [HttpGet]
        public IActionResult GetAllData()
        {
            var result = _contactInfoRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                //var List = new List<ContactInfoDto>();

                //foreach (var i in result)
                //{
                //    List.Add(_mapper.Map<ContactInfoDto>(i));
                //}

                return Ok(result);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }


        /// <summary>  
        /// Get UnSolved ContactInfo Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get UnSolved ContactInfo Details Availabe in Database 
        /// </remarks> 

        //GET : api/contactinfo/unsolved
        [HttpGet("unsolved")]
        public IActionResult GetUnSolvedData()
        {
            var result = _contactInfoRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var List = new List<ContactInfoDto>();
                var data = result.Where(a => a.IsSolved == false);
                if(data != null)
                {
                    foreach (var i in data)
                    {
                        List.Add(_mapper.Map<ContactInfoDto>(i));
                    }

                    return Ok(List);
                }
                else
                {
                    return NotFound("Required Data Not Available In Database!!!");
                }
                
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }
        }




        /// <summary>  
        /// Get Solved ContactInfo Details  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Solved ContactInfo Details Availabe in Database 
        /// </remarks> 

        //GET : api/contactinfo/solved
        [HttpGet("solved")]
        public IActionResult GetSolvedData()
        {
            var result = _contactInfoRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var List = new List<ContactInfoDto>();
                var data = result.Where(a => a.IsSolved == true);
                if (data != null)
                {
                    foreach (var i in data)
                    {
                        List.Add(_mapper.Map<ContactInfoDto>(i));
                    }

                    return Ok(List);
                }
                else
                {
                    return NotFound("Required Data Not Available In Database!!!");
                }

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
        /// return sorted based on Name
        /// </remarks> 

        //GET : api/contactinfo/sorted/sortid
        [HttpGet("sorted/{sortid}")]
        [Authorize(Roles = "admin,deliveryboy")]
        public IActionResult GetAscSortedData(int sortid)
        {
            var sortedData = _contactInfoRepository.GetSortedData(sortid);
            if (sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound();
            }

        }


        /// <summary>  
        /// Get ContactInfo Data by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get ContactInfo Data by Id Provided by User 
        /// </remarks> 

        //GET : api/contactinfo/id
        [HttpGet("{Id}")]
        public IActionResult GetDataById(int Id)
        {
            //throw an Error if data is empty
            if (_contactInfoRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _contactInfoRepository.GetById(Id);
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
        /// Create ContactInfo Data
        /// </summary>   
        /// <param name="contactInfo"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new ContactInfo Data into the Database 
        /// </remarks> 

        //POST : api/contactinfo
        [HttpPost]
        public IActionResult InsertData(ContactInfo contactInfo)
        {
            ///try to Generate new Field If any Error occurs Return False
            var result = _contactInfoRepository.Create(contactInfo);
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
        /// Update ContactInfo Data  
        /// </summary>  
        /// <param name="contactInfo"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update ContactInfo Data By Given Id into JSON
        /// </remarks>  

        //PUT : api/contactinfo
        [HttpPut]
        public IActionResult UpdateData(ContactInfo contactInfo)
        {
            var result = _contactInfoRepository.Update(contactInfo);
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
        /// Delete ContactInfo Data
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete ContactInfo Data By Given Id
        /// </remarks>  

        //DELETE : api/contactinfo
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int Id)
        {
            var result = _contactInfoRepository.Delete(Id);
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
