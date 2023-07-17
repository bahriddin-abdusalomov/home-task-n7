using HomeTask_13_07_2023.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_13_07_2023.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = localhost;" +
                "Port = 5432;" +
                "User Id = postgres;" +
                "Password = salom;" +
                "Database = HomeTask;";

            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<User>  Users { get; set; }
    }
}
