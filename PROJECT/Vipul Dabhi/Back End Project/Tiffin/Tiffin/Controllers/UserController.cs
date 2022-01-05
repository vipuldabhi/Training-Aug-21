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
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        /// <summary>  
        /// Get All Users Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Users Details Availabe in Database 
        /// </remarks> 

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAllUserData()
        {
            var result = _userRepository.GetAll();
            ///throw an Error if data is empty
            if (result.Any())
            {
                var data = result.Where(a => a.IsDeleted == false);
                if (data.Any())
                {
                    var UserList = new List<UserDto>();
                    foreach (var i in data)
                    {
                        UserList.Add(_mapper.Map<UserDto>(i));
                    }

                    return Ok(UserList);
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
        /// Get UserDetails by Given Id  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get Users Details by Id Provided by User 
        /// </remarks> 

        [HttpGet("{Id}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetUserById(int Id)
        {
            //throw an Error if data is empty
            if (_userRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _userRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    return Ok(_mapper.Map<UserDto>(data));
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
        /// Create User
        /// </summary>   
        /// <param name="user"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Create new User into the Database 
        /// </remarks> 

        [HttpPost]
        [Authorize(Roles = "user,admin,deliveryboy")]
        public IActionResult InsertUser(User user)
        {
            if (user.IsDeleted == false)
            {
                ///try to Generate new Field If any Error occurs Return False
                var result = _userRepository.Create(user);
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
        /// Update UsersDetail  
        /// </summary>  
        /// <param name="user"></param>  
        /// <returns></returns>  
        /// <remarks>  
        /// Update UsersDetail By Given Id into Data
        /// </remarks>  

        [HttpPut]
        [Authorize(Roles = "user,admin,deliveryboy")]
        public IActionResult UpdateUser(User user)
        {
            if (user.IsDeleted == false)
            {
                var result = _userRepository.Update(user);
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
        /// Delete User
        /// </summary>  
        /// <returns></returns>  
        /// <remarks>  
        /// Delete User By Given Id
        /// </remarks>  

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteUser(int Id)
        {
            var result = _userRepository.Delete(Id);
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
