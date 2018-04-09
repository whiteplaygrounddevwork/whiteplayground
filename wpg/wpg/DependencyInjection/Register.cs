using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wpg.Core.Interfaces;
using wpg.Infrastructure.Implementation;
using wpg.Infrastructure.Models;
using wpg.Infrastructure.Repository;
using wpg.Infrastructure.Repository.Implementation;

namespace wpg.DependencyInjection
{
    public static class Register
    {
        public static void Dependencies(IServiceCollection services)
        {
            services.AddTransient<DbContext, WPGContext>();
            services.AddTransient<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            services.AddTransient<IRoleStore<IdentityRole>, RoleStore<IdentityRole>>();
            services.AddTransient<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
            services.AddTransient<IAccount, Account>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
