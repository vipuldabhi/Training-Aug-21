using Day17.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
        Task<IdentityResult> SignUpAdminAsync(SignUpModel signUpModel);
        Task<string> LoginAdminAsync(SignInModel signInModel);
    }
}
