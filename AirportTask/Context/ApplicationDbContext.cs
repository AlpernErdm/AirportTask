using AirportTask.Model;
using Microsoft.EntityFrameworkCore;

namespace AirportTask.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Runway19> Runway19 { get; set; }
        public DbSet<Runway22> Runway22 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Runway19>().HasKey(a => a.AirportIcaoIdentifier); //Runway19 için primary Key
            modelBuilder.Entity<Runway22>().HasKey(a => a.AirportIcaoIdentifier); //Runway22 için primary Key
        }
    }
}
