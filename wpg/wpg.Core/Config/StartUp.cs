using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using wpg.Core.DTO;

namespace wpg.Core.Config
{
   //App Start up settings
   public static class StartUp
    {
        //public static void Settings(IServiceCollection services,string Constring)
        //{
        //    services.AddDbContext<wpg_devContext>(options =>
        //       options.UseSqlServer(Constring));

        //    services.AddIdentity<ApplicationUser, IdentityRole>()
        //        .AddEntityFrameworkStores<wpg_devContext>()
        //        .AddDefaultTokenProviders();

        //    services.Configure<IdentityOptions>(options =>
        //    {
        //        // Password settings
        //        options.Password.RequireDigit = true;
        //        options.Password.RequiredLength = 8;
        //        options.Password.RequireNonAlphanumeric = false;
        //        options.Password.RequireUppercase = true;
        //        options.Password.RequireLowercase = false;
        //        options.Password.RequiredUniqueChars = 6;

        //        // Lockout settings
        //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
        //        options.Lockout.MaxFailedAccessAttempts = 10;
        //        options.Lockout.AllowedForNewUsers = true;

        //        // User settings
        //        options.User.RequireUniqueEmail = true;
        //    });

        //    services.ConfigureApplicationCookie(options =>
        //    {
        //        // Cookie settings
        //        options.Cookie.HttpOnly = true;
        //        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        //        // If the LoginPath isn't set, ASP.NET Core defaults 
        //        // the path to /Account/Login.
        //        options.LoginPath = "/Account/Login";
        //        // If the AccessDeniedPath isn't set, ASP.NET Core defaults 
        //        // the path to /Account/AccessDenied.
        //        options.AccessDeniedPath = "/Account/AccessDenied";
        //        options.SlidingExpiration = true;
        //    });
        //}
    }
}
