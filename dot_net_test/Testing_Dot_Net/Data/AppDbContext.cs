using Microsoft.EntityFrameworkCore;
using System;
using Testing_Dot_Net.Models;

namespace Testing_Dot_Net.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
