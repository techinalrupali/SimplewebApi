using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimplewebApi.Model;


namespace SimplewebApi.Entities
{
    public class RepositoriesContext:DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Course> courses{ get; set; }

    }
}
