using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tiffin.Entities;
using Tiffin.Repository;

namespace Tiffin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }


        /// <summary>  
        /// SignUp for Admin  
        /// </summary>    
        /// <param name="signUpModel"></param>
        /// <returns></returns>  
        /// <remarks>  
        /// SignUp Method for Admin it Takes Credentials of JSON type from Body 
        /// </remarks> 
        /// 
        [HttpPost("signup/admin")]
        public async Task<IActionResult> SignUpAdmin([FromBody] SignUpModel signUpModel)
        {

            var result = await _accountRepository.SignUpAdminAsync(signUpModel);

            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }

            return Unauthorized();
        }



        /// <summary>  
        /// SignUp for DeliveryBoy  
        /// </summary>    
        /// <param name="signUpModel"></param>
        /// <returns></returns>  
        /// <remarks>  
        /// SignUp Method for DeliveryBoy it Takes Credentials of JSON type from Body 
        /// </remarks> 
        /// 
        [HttpPost("signup/deliveryboy")]
        public async Task<IActionResult> SignUpDeliveryBoy([FromBody] SignUpModel signUpModel)
        {
            var result = await _accountRepository.SignUpDeliveryBoyAsync(signUpModel);

            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }

            return Unauthorized();
        }




        /// <summary>  
        /// SignUp for all Users  
        /// </summary>    
        /// <param name="signUpModel"></param>
        /// <returns></returns>  
        /// <remarks>  
        /// SignUp Method for all Users it Takes Credentials of JSON type from Body 
        /// </remarks> 
        /// 
        [HttpPost("signup/user")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel signUpModel)
        {
            var result = await _accountRepository.SignUpAsync(signUpModel);

            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }

            return Unauthorized();
        }




        /// <summary>  
        /// Login for all User  
        /// </summary>    
        /// <param name="signInModel"></param>
        /// <returns></returns>  
        /// <remarks>  
        /// Login Method for all Users it Takes Credentials of JSON type from Body 
        /// </remarks> 
        /// 
        [HttpPost("login/user")]
        public async Task<IActionResult> Login([FromBody] SignInModel signInModel)
        {
            var result = await _accountRepository.LoginAsync(signInModel);

            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }

            return Ok(result);
        }



        /// <summary>  
        /// Login for Admin 
        /// </summary>    
        /// <param name="signInModel"></param>
        /// <returns></returns>  
        /// <remarks>  
        /// Login Method for Admin it Takes Credentials of JSON type from Body 
        /// </remarks> 
        /// 
        [HttpPost("login/admin")]
        public async Task<IActionResult> LoginAsAdmin([FromBody] SignInModel signInModel)
        {
            var result = await _accountRepository.LoginAdminAsync(signInModel);

            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }

            return Ok(result);
        }




        /// <summary>  
        /// Login for DeliveryBoy 
        /// </summary>    
        /// <param name="signInModel"></param>
        /// <returns></returns>  
        /// <remarks>  
        /// Login Method for DeliveryBoy it Takes Credentials of JSON type from Body 
        /// </remarks> 
        /// 
        [HttpPost("login/deliveryboy")]
        public async Task<IActionResult> LoginDeliveryBoy([FromBody] SignInModel signInModel)
        {
            var result = await _accountRepository.LoginDeliveryBoyAsync(signInModel);

            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }

            return Ok(result);
        }
    }
}
