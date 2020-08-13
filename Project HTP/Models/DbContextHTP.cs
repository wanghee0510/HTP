using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_HTP.Models
{
    public class DbContextHTP:DbContext
    {
        public DbContextHTP()
        {
        }
        public DbContextHTP(DbContextOptions<DbContextHTP> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<StudentList> StudentLists { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }
    }
}
