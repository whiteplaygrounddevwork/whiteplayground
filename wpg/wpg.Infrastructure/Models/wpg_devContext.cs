using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace wpg.Infrastructure.Models
{
   

    public partial class wpg_devContext : IdentityDbContext<ApplicationUser>
    {

        public wpg_devContext(DbContextOptions<wpg_devContext> options)
            : base(options)
        { }

        public virtual DbSet<Customer> Customer { get; set; }
    }
}
