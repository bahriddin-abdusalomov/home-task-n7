using HomaTask_14_07_2023.Data;
using HomaTask_14_07_2023.Models;
using Microsoft.EntityFrameworkCore;

namespace HomaTask_14_07_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Staff> staffs = new List<Staff>()
            {
                new Staff()
                {
                    StaffId = 1,
                    Name = "Google",
                    Description = "Best Company",
                },

                new Staff()
                {
                    StaffId = 2,
                    Name = "Epam",
                    Description = "Big Company",
                },
                new Staff()
                {
                    StaffId = 3,
                    Name = "Exadel",
                    Description = "Company",
                }
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                   FirstName = "Muhammad",
                   LastName = "Hamdamov",
                   Email = "muhammad@gmail.com",
                   Password = "12wuiefwebfwe3",
                   StaffId = 1,
                },
                new Employee()
                {
                    FirstName = "Ali",
                    LastName = "Valiyev",
                    Email = "ali@gmail.com",
                    Password = "sdiusfhweuafwe12r343",
                    StaffId = 2,
                },
                new Employee()
                {
                   FirstName = "Vali",
                   LastName = "Jumayev",
                   Email = "jumah@gmail.com",
                   Password = "jwefjwiuefwe3289342",
                   StaffId = 3,
                },
                new Employee()
                {
                    FirstName = "Jasur",
                    LastName = "Ubaydullayev",
                    Email = "jaska@gmail.com",
                    Password = "wefw129u4nsd",
                    StaffId = 1,
                },
                new Employee()
                {
                    FirstName = "Ibrat",
                    LastName = "Ibrohimov",
                    Email = "ibrat@gmail.com",
                    Password = "dkwehcw901",
                    StaffId = 2,
                },
                new Employee()
                {
                    FirstName = "Laziz",
                    LastName = "Xoshimov",
                    Email = "xoshimov@gmail.com",
                    Password = "sdbwfj9823r98",
                    StaffId = 3,
                },
                new Employee()
                {
                    FirstName = "Sanjar",
                    LastName = "Mirzaahmedov",
                    Email = "sanjar@gmail.com",
                    Password = "jhsdbfwh9832r",
                    StaffId = 1,
                }

            };

            var db = new CompanyDbContext();

            //db.Staffs.AddRange(staffs);
            //db.SaveChanges();

            //db.Employees.AddRange(employees);
            //db.SaveChanges();

            var res = db.Staffs.Include(a => a.Employees).ToList();

            foreach (var item in res)
            {
                Console.WriteLine();
                Console.WriteLine(item.Name);
                foreach (var item1 in item.Employees)
                {
                    Console.WriteLine("-----" + item1.FirstName);
                }
            }

        }
    }
}