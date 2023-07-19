using Microsoft.EntityFrameworkCore;
using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Data
{
    public class GmDbContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = localhost;" +
                "Port = 5432;" +
                "User Id = postgres;" +
                "Password = salom;" +
                "Database = GMDB;";

            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddData(modelBuilder);
        }

        public void AddData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData
                (
                    new Car()
                    {
                        Id = 1,
                        Name = "Nexia 1",
                        Speed = 140
                    },
                    new Car() 
                    { 
                        Id = 2,
                        Name = "Nexia 2",
                        Speed = 180
                    },
                    new Car()
                    {
                        Id =3,
                        Name = "Nexia 3",
                        Speed = 200
                    }
                );
            modelBuilder.Entity<Bus>().HasData
                (
                     new Bus()
                     {
                         Id = 1,
                         Name = "Uzb Bus",
                         Speed  = 100
                     },
                     new Bus()
                     {
                         Id =2,
                         Name = "Electro Bus",
                         Speed = 120
                     },
                     new Bus()
                     {
                         Id = 3,
                         Name = "Fast Bus",
                         Speed = 160
                     }
                );
            modelBuilder.Entity<Client>().HasData
                (
                    new Client()
                    {
                        Id = 1,
                        Name = "Bahriddin"
                    },
                    new Client()
                    {
                        Id =2,
                        Name = "JasurBek"
                    },
                    new Client()
                    {
                        Id = 3,
                        Name = "LazizBek"
                    }
                );
        }
    }
}
