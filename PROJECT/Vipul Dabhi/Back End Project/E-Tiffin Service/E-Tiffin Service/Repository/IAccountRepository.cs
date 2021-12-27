using E_Tiffin_Service.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
        Task<IdentityResult> SignUpAdminAsync(SignUpModel signUpModel);
        Task<string> LoginAdminAsync(SignInModel signInModel);
        Task<IdentityResult> SignUpDeliveryBoyAsync(SignUpModel signUpModel);
        Task<string> LoginDeliveryBoyAsync(SignInModel signInModel);

    }
}
