using HomeTask_18_07_2023.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_18_07_2023.Data
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = localhost;" +
                "Port = 5432;" +
                "User Id = postgres;" +
                "Password = salom;" +
                "Database = Address");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddData(modelBuilder);
        }

        void AddData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData
                (
                    new Address()
                    {
                        AddressId = 1,
                        City = "Qo'qon",
                        District = "Dang'ara"
                    },
                    new Address()
                    {
                      AddressId = 2,
                      City = "Toshkent",
                      District = "Chilonzor"
                    }
                );

            modelBuilder.Entity<User>().HasData
                (
                    new User()
                    {
                        UserId = 1,
                        Name = "Bahriddin",
                        AddressId = 1,
                    },

                    new User()
                    {
                        UserId = 2,
                        Name = "Jasur",
                        AddressId = 1,
                    },
                    new User()
                    {
                        UserId= 3,
                        Name = "Sarvar",
                        AddressId = 2,
                    }
                );
        }
    }
}
