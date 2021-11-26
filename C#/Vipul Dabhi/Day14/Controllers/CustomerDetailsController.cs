using Day14.Models;
using Day14.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDetailsController : ControllerBase
    {
        private readonly ICustomerRepository _toyRepository;

        public CustomerDetailsController(ICustomerRepository toyRepository )
        {
            _toyRepository = toyRepository;
        }

        [HttpGet("get-customers")]
        public async Task<ActionResult> GetCustomers()
        {
            try
            {
                return Ok(await _toyRepository.GetCustomers());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro in Retriving Data From Database ");
            }
        }

        [Route("Delete-customer/{id}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            try
            {
                int i = id;
                return Ok(await _toyRepository.DeleteCustomer(i));
                 
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro in Retriving Data From Database ");
            }
        }

        [HttpPost("")]
        public async Task<ActionResult> AddCustomer(CustomerDetails customer)
        {
            try
            {
                return Ok(await _toyRepository.AddCustomer(customer));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro in Retriving Data From Database ");

            }
        }
    }
}
