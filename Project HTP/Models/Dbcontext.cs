using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_HTP.Models
{
    public class Dbcontext: DbContext
    {
        public Dbcontext()
        {

        }
        public Dbcontext(DbContextOptions<Dbcontext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<LoginUser> loginUsers { get; set; }
    }
}
