using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wkmvc.Data.Models.SysModelsMange;

namespace wkmvc.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
 : base(options)
        {
        }

        public DbSet<SYS_USER> SYS_USER { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {



            base.OnModelCreating(builder);
        }
    }
}
