//using AutoMapper.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tiffin.Entities;
using Tiffin.Helpers;
using Microsoft.AspNetCore.Http;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly tiffinContext _context;

        public AccountRepository(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                IConfiguration configuration,
                                RoleManager<IdentityRole> roleManager,
                                tiffinContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _roleManager = roleManager;
            _context = context;
        }


        /// <summary>
        /// SignUp Method for common Users
        /// </summary>
        /// <param name="signUpModel"></param>
        /// <returns></returns>

        public async Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = signUpModel.FirstName,
                LastName = signUpModel.LastName,
                Email = signUpModel.Email,
                UserName = signUpModel.Email
            };

            var result = await _userManager.CreateAsync(user, ManagePassword.ConvertToEncrypt(signUpModel.Password));

            if (!await _roleManager.RoleExistsAsync(UserRoles.User))
            {
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                await _userManager.AddToRoleAsync(user, UserRoles.User);
            }
            else
            {
                await _userManager.AddToRoleAsync(user, UserRoles.User);
            }
            return result;
        }


        /// <summary>
        /// SignUp Method for Admin
        /// </summary>
        /// <param name="signUpModel"></param>
        /// <returns></returns>
        public async Task<IdentityResult> SignUpAdminAsync(SignUpModel signUpModel)
        {

            if (signUpModel.Email == "admin@gmail.com" && signUpModel.Password == "Admin@123")
            {
                var admin = new ApplicationUser()
                {
                    FirstName = signUpModel.FirstName,
                    LastName = signUpModel.LastName,
                    Email = signUpModel.Email,
                    UserName = signUpModel.Email
                };

                var result = await _userManager.CreateAsync(admin, ManagePassword.ConvertToEncrypt(signUpModel.Password));

                if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                    await _userManager.AddToRoleAsync(admin, UserRoles.Admin);
                }
                else
                {
                    await _userManager.AddToRoleAsync(admin, UserRoles.Admin);
                }
                return result;
            }
            else
            {
                return IdentityResult.Failed();
            }

        }



        /// <summary>
        /// SignUp Method for DeliveryBoy
        /// </summary>
        /// <param name="signUpModel"></param>
        /// <returns></returns>
        public async Task<IdentityResult> SignUpDeliveryBoyAsync(SignUpModel signUpModel)
        {
            var deliveryboy = new ApplicationUser()
            {
                FirstName = signUpModel.FirstName,
                LastName = signUpModel.LastName,
                Email = signUpModel.Email,
                UserName = signUpModel.Email
            };

            var result = await _userManager.CreateAsync(deliveryboy, ManagePassword.ConvertToEncrypt(signUpModel.Password));

            if (!await _roleManager.RoleExistsAsync(UserRoles.DeliveryBoy))
            {
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.DeliveryBoy));
                await _userManager.AddToRoleAsync(deliveryboy, UserRoles.DeliveryBoy);
            }
            else
            {
                await _userManager.AddToRoleAsync(deliveryboy, UserRoles.DeliveryBoy);
            }
            return result;
        }




        /// <summary>
        /// Login Method for common Users
        /// </summary>
        /// <param name="signInModel"></param>
        /// <returns></returns>
        public async Task<TokenModel> LoginAsync(SignInModel signInModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, ManagePassword.ConvertToEncrypt(signInModel.Password), false, false);

            if (!result.Succeeded)
            {
                TokenModel tokenerrorModel = new TokenModel();
                tokenerrorModel.Status = false;
                //tokenerrorModel.Token = "";
                return tokenerrorModel;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,signInModel.Email),
                new Claim(ClaimTypes.Role,"user"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            ///generate a token for common User login

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            var mytoken = new JwtSecurityTokenHandler().WriteToken(token);

            var User = _context.Users.FirstOrDefault(a => a.Email == signInModel.Email);
            if(User == null)
            {
                TokenModel tokenerrorModel = new TokenModel();
                tokenerrorModel.Status = false;
                return tokenerrorModel;
            }
            else
            {
                TokenModel tokenModel = new TokenModel();
                tokenModel.Status = true;
                tokenModel.Token = mytoken;
                tokenModel.Id = User.UserId;

                return tokenModel;
            }
        }



        /// <summary>
        /// Login Method for Admin
        /// </summary>
        /// <param name="signInModel"></param>
        /// <returns></returns>
        public async Task<TokenModel> LoginAdminAsync(SignInModel signInModel)
        {
            if (signInModel.Email == "admin@gmail.com" && signInModel.Password == "Admin@123")
            {
                var result = await _signInManager.PasswordSignInAsync(signInModel.Email, ManagePassword.ConvertToEncrypt(signInModel.Password), false, false);

                if (!result.Succeeded)
                {
                    TokenModel tokenerrorModel = new TokenModel();
                    tokenerrorModel.Status = false;
                    return tokenerrorModel;
                }

                var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,signInModel.Email),
                new Claim(ClaimTypes.Role,"admin"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

                var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

                ///generate a token for admin login

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                var mytoken = new JwtSecurityTokenHandler().WriteToken(token);
                TokenModel tokenModel = new TokenModel();
                tokenModel.Status = true;
                tokenModel.Token = mytoken;

                return tokenModel;

            }
            else
            {
                TokenModel tokenerrorModel = new TokenModel();
                tokenerrorModel.Status = false;
                return tokenerrorModel;
            }

        }
               


        /// <summary>
        /// Login Method for DeliveryBoy
        /// </summary>
        /// <param name="signInModel"></param>
        /// <returns></returns>
        public async Task<TokenModel> LoginDeliveryBoyAsync(SignInModel signInModel)
        {          
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, ManagePassword.ConvertToEncrypt(signInModel.Password), false, false);

            if (!result.Succeeded)
            {
                TokenModel tokenerrorModel = new TokenModel();
                tokenerrorModel.Status = false;
                return tokenerrorModel;    
            }
                                                                                            
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,signInModel.Email),
                new Claim(ClaimTypes.Role,"deliveryboy"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            ///generate a token for delivery boy login
            
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            var mytoken = new JwtSecurityTokenHandler().WriteToken(token);
            var deliveryboy = _context.DeliveryBoys.FirstOrDefault(a => a.Email == signInModel.Email);
            if(deliveryboy == null)
            {
                TokenModel tokenerrorModel = new TokenModel();
                tokenerrorModel.Status = false;
                return tokenerrorModel;
            }
            else
            {
                TokenModel tokenModel = new TokenModel();
                tokenModel.Status = true;
                tokenModel.Token = mytoken;
                tokenModel.Id = deliveryboy.Id;

                return tokenModel;
            }

        }

    }
}
