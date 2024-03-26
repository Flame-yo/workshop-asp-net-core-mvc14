using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc14.Models;

namespace SalesWebMvc14.Data
{
    public class SalesWebMvc14Context : DbContext
    {
        public SalesWebMvc14Context (DbContextOptions<SalesWebMvc14Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
