using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace OnlineCalendarSystem_Tier1.Data{
    public class AppDbContext:DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }

        public DbSet<users> users {
            get;set;
      }
    }
}