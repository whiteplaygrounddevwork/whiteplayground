using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using wpg.Core.Interfaces;
using wpg.Infrastructure.Models;

namespace wpg.Infrastructure.Implementation
{
    public class Account : IAccount
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public Account(
             UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<string> Login(string email, string password,bool remeberMe)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(email, password, remeberMe, lockoutOnFailure: false);

               
               

                if (result.Succeeded)
                {
                    return "Success";
                }
                if (result.RequiresTwoFactor)
                {
                    return "Need2FA";
                    //return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    return "User account locked out.";
                }
                else
                {
                    // ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return "Invalid login attempt.";
                }
            }
            catch (Exception ex)
            {
                return "Error Login" + ex.Message;
            }

            
        }

        public async Task<string> Register(string email, string password, string returnUrl = null)
        {
            try
            {
                string code = string.Empty;
                var user = new ApplicationUser { UserName = email, Email = email };

                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }
                return code;
            }
            catch (Exception ex)
            {
                return "Failed : "+ex.Message;
            }
        }
    }
}
