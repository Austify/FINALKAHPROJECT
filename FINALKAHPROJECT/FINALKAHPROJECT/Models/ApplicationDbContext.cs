using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FINALKAHPROJECT.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
    }
}
