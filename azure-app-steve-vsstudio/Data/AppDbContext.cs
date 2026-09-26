using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace azure_app_steve_vsstudio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
