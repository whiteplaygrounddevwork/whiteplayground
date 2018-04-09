using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace wpg.Infrastructure.Models
{
   

    public partial class WPGContext : IdentityDbContext<ApplicationUser>
    {

        public WPGContext(DbContextOptions<WPGContext> options)
            : base(options)
        { }
    }
}
