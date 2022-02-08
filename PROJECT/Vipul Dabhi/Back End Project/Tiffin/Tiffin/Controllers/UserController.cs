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
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository,IAreaRepository areaRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _areaRepository = areaRepository;
            _mapper = mapper;
        }


        //get User Id By Email


        //GET : api/user/userid/{email}
        [HttpGet("userid/{email}")]
        [Authorize(Roles = "user,deliveryboy,admin")]

        public IActionResult GetUserIdByEmail(string email)
        {
            var claims = User.Claims.ToList();
            var Email = claims[0].Value;

            int userId = _userRepository.getUserId(email);

            if (userId != 0)
            {
                return Ok(userId);
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
        /// return sorted  Data
        /// </remarks> 

        ///GET : api/user/sorted/sortid/refid   //refid 3 for based on firstname and 4 for lastname
        [HttpGet("sorted/{sortid}/{refid}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetSortedUsers(int sortid, int refid)
        {
            var sortedData = _userRepository.GetSortedData(sortid, refid);
            if (sortedData != null)
            {
                return Ok(sortedData);
            }
            else
            {
                return NotFound();
            }

        }


        //getUser By Email

        //GET : api/user/userdetails/{email}
        [HttpGet("userdetails/{email}")]
        [Authorize(Roles = "user,deliveryboy,admin")]

        public IActionResult GetUserDetails(string email)
        {
            var claims = User.Claims.ToList();
            var Email = claims[0].Value;

            var user = _userRepository.getByEmail(email);

            if (user!= null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound("Data Not Available In Database!!!");
            }

        }



        /// <summary>  
        /// Get All Users Data  
        /// </summary>    
        /// <returns></returns>  
        /// <remarks>  
        /// Get all Users Details Availabe in Database 
        /// </remarks> 

        //GET : api/user
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
                    var area = _areaRepository.GetAll();
                    foreach (var i in data)
                    {
                        var x = _mapper.Map<UserDto>(i);
                        var Area = area.FirstOrDefault(a => a.AreaId == i.AreaId);
                        x.AreaName = Area.AreaName;
                        UserList.Add(x);
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

        //GET : api/user/id
        [HttpGet("{Id}")]
        [Authorize(Roles = "admin,user,deliveryboy")]
        public IActionResult GetUserById(int Id)
        {
            //throw an Error if data is empty
            if (_userRepository.GetAll().Any())
            {
                //Match Data With Provided Id Into Url
                var data = _userRepository.GetById(Id);
                if (data != null && data.IsDeleted == false)
                {
                    var x = _mapper.Map<UserDto>(data);
                    var area = _areaRepository.GetById(x.AreaId);
                    x.AreaName = area.AreaName;
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
        /// Create User
        /// </summary>  
        /// <param name="user"></param>
        /// <returns></returns>
        /// <remarks>
        /// Create new User into the Database
        /// </remarks>    

        //POST : api/user
        [HttpPost]
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

        //PUT : api/user
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

        //DELETE : api/user/id
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
                return BadRequest();
            }
        }
    }
}
