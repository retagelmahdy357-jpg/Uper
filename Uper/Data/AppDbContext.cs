using Microsoft.EntityFrameworkCore;
using Uper.Model;

namespace Uper.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<AppUser> appUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasOne(x => x.Driver).WithOne(x => x.Vehicle).HasForeignKey<Vehicle>(x => x.DriverId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Payment>().HasOne(x => x.Ride).WithOne(x => x.Payment).HasForeignKey<Payment>(x => x.RideId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Rating>().HasOne(x => x.Ride).WithOne(x => x.Rating).HasForeignKey<Rating>(x => x.RideId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Ride>().HasOne(x => x.Rider).WithMany(x => x.RideRiders).HasForeignKey(x => x.RiderId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Ride>().HasOne(x => x.Driver).WithMany(x => x.RideDrivers).HasForeignKey(x => x.DriverId).OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<User>().HasData(
    new User
    {
        Id = 1,
        FullName = "Ahmed Mohamed",
        Email = "ahmed@gmail.com",
        Password = "Ahmed@123",
        Phone = "01012345678",
        Role = "Driver"
    },
    new User
    {
        Id = 2,
        FullName = "Omar Ali",
        Email = "omar@gmail.com",
        Password = "Omar@123",
        Phone = "01112345678",
        Role = "Driver"
    },
    new User
    {
        Id = 3,
        FullName = "Sara Ahmed",
        Email = "sara@gmail.com",
        Password = "Sara@123",
        Phone = "01212345678",
        Role = "Rider"
    },
    new User
    {
        Id = 4,
        FullName = "Mona Ali",
        Email = "mona@gmail.com",
        Password = "Mona@123",
        Phone = "01512345678",
        Role = "Rider"
    },
     new User
     {
         Id = 5,
         FullName = "Retag Ebraheim",
         Email = "Retaggmail.com",
         Password = "retag@123",
         Phone = "01112345678",
         Role = "Admin"
     }
);

            // Vehicles
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 1,
                    Model = "Toyota Corolla",
                    PlateNumber = "ABC123",
                    Color = "White",
                    DriverId = 1
                },
                new Vehicle
                {
                    Id = 2,
                    Model = "Hyundai Elantra",
                    PlateNumber = "XYZ456",
                    Color = "Black",
                    DriverId = 2
                }
            );

            // Rides
            modelBuilder.Entity<Ride>().HasData(
                new Ride
                {
                    Id = 1,
                    PickupLocation = "Cairo",
                    DropOffLocation = "Giza",
                    Fare = 100,
                    Status = "Completed",
                    RiderId = 3,
                    DriverId = 1
                },
                new Ride
                {
                    Id = 2,
                    PickupLocation = "Nasr City",
                    DropOffLocation = "Maadi",
                    Fare = 150,
                    Status = "Pending",
                    RiderId = 4,
                    DriverId = 2
                },
                new Ride
                {
                    Id = 3,
                    PickupLocation = "Dokki",
                    DropOffLocation = "October",
                    Fare = 200,
                    Status = "Completed",
                    RiderId = 3,
                    DriverId = 2
                }
            );

            // Payments
            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    Id = 1,
                    Amount = 100,
                    PaymentMethod = "Cash",
                    PaymentDate = new DateTime(2026, 10, 10),
                    Status = "Paid",
                    RideId = 1
                },
                new Payment
                {
                    Id = 2,
                    Amount = 150,
                    PaymentMethod = "Card",
                    PaymentDate = new DateTime(2026, 10, 11),
                    Status = "Pending",
                    RideId = 2
                }
            );

            // Ratings
            modelBuilder.Entity<Rating>().HasData(
                new Rating
                {
                    Id = 1,
                    Score = 5,
                    Comment = "Excellent driver",
                    RideId = 1
                },
                new Rating
                {
                    Id = 2,
                    Score = 4,
                    Comment = "Good ride",
                    RideId = 3
                }
            );
            modelBuilder.Entity<AppUser>().HasData(
    new AppUser
    {
        Id = 1,
        FullName = "Ali Mohamed",
        email = "Ali@example.com",
        password = "Password123",
        Role = "Driver"
    },
    new AppUser
    {
        Id = 2,
        FullName = "Karma Ahmed",
        email = "Karma@example.com",
        password = "Password123",
        Role = "Rider"
    },
    new AppUser
    {
        Id = 3,
        FullName = "Fatma Ebrahem",
        email = "Ebrahem@example.com",
        password = "Password123",
        Role = "Driver"
    }
);

        }

    }
    }
            

       
       
            

            
                
                
            