using HomeTask_18_07_2023.Data;
using HomeTask_18_07_2023.Models;
using HomeTask_18_07_2023.Services;
using Microsoft.EntityFrameworkCore;

namespace HomeTask_18_07_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Address> addresses = new List<Address>()
            {
                new Address ()
                {
                    AddressId = 3,
                    City = "Fargona",
                    District = "Kirgili",
                },
                new Address ()
                {
                    AddressId= 4,
                    City = "Toshkent",
                    District = "Yunusobod"
                }
            };

            List<User> users = new List<User>()
            {
                new User ()
                {
                    UserId = 4,
                    Name = "Ijodbek",
                    AddressId = 3
                },
                new User ()
                {
                    UserId = 5,
                    Name = "Lazizbek",
                    AddressId = 4
                },
                new User ()
                {
                    UserId = 6,
                    Name = "Sanjarbek",
                    AddressId = 1
                }
            };

            DBContext dbContext = new DBContext();

            DbMethod<Address> addressMethod = new DbMethod<Address>();
            addressMethod.AddRange(addresses);

            DbMethod<User> userMethod = new DbMethod<User>();
             userMethod.AddRange(users);

            var result = dbContext.Addresses.Include(x => x.Users).FirstOrDefault(x => x.AddressId == 1);

            Console.WriteLine(result.City);
            Console.WriteLine(result.District);

            foreach (var item in result.Users)
            {
                Console.WriteLine();
                Console.WriteLine("--------" + item.Name);
            }


        }   
    }
}