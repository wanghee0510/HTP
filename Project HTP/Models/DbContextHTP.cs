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
        public DbSet<StudentList> StudentLists { get; set; }
    }
}
