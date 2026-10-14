using Microsoft.EntityFrameworkCore;
using Uper.Model;

namespace Uper.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>option):base(option) { }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Ride> Rides { get; set; }  
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<AppUser>appUsers { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasOne(x => x.Driver).WithOne(x => x.Vehicle).HasForeignKey<Vehicle>(x => x.DriverId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Payment>().HasOne(x => x.Ride).WithOne(x => x.Payment).HasForeignKey<Payment>(x => x.RideId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Rating>().HasOne(x => x.Ride).WithOne(x => x.Rating).HasForeignKey<Rating>(x => x.RideId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Ride>().HasOne(x=>x.Rider).WithMany(x=>x.RideRiders).HasForeignKey(x=>x.RiderId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Ride>().HasOne(x=>x.Driver).WithMany(x=>x.RideDrivers).HasForeignKey(x=>x.DriverId).OnDelete(DeleteBehavior.Restrict);






            base.OnModelCreating(modelBuilder);
        }

    }
}
