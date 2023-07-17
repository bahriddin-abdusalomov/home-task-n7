using HomaTask_14_07_2023.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomaTask_14_07_2023.Data
{
    public class CompanyDbContext : DbContext
    {
        public string connectionString = "Server = localhost;" +
         "Port = 5432;" +
         "User Id = postgres;" +
         "Password = salom;" +
         "Database = Company;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
