using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Helpers.DBContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options) {}
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=9999;Database=base_c_sharp;Username=postgres;Password=postgres");
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}