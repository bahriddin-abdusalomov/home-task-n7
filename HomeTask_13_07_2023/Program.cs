using HomeTask_13_07_2023.Data;
using HomeTask_13_07_2023.Enum;
using HomeTask_13_07_2023.Models;
using HomeTask_13_07_2023.Service;

namespace HomeTask_13_07_2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                   FirstName = "Bahriddin",
                   LastName = "Abdusalomov",
                   Age = 20,
                   Email = "bahriddin@gmail.com",
                   Password = "password234567",
                   Gender = Gender.Male,
                },
                new User()
                {
                    FirstName = "Lazizbek",
                    LastName = "Xoshimov",
                    Age = 20,
                    Email = "laziz@gmail.com",
                    Password = "laziz893489y43",
                    Gender = Gender.Male,
                },
                new User()
                {
                    FirstName = "Nodira",
                    LastName = "Murotova",
                    Age = 23,
                    Email = "murotova@gmail.com",
                    Password = "nodira2323",
                    Gender = Gender.Female,
                },
                new User()
                {
                    FirstName = "Odina",
                    LastName = "Soliyeva",
                    Age = 24,
                    Email = "odina0404@gmail.com",
                    Password = "odina04042000",
                    Gender = Gender.Female,
                },
                new User()
                {
                    FirstName = "Jasurbek",
                    LastName = "Ubaydulllayev",
                    Age = 25,
                    Email = "ubaydullayev@gmail.com",
                    Password = "jasurkhan21",
                    Gender = Gender.Male,
                }
            };

            DbMethods dbm = new DbMethods();
            // Add values

            dbm.AddRange(users);

            //Delete row

            //var db = new AppDbContext();
            //var user = db.Users.First(user => user.UserId == 6);
            //dbm.Delete(user);

            // Update data

            //var db = new AppDbContext();
            //var user = db.Users.First(user => user.FirstName == "Nodira");

            //user.FirstName = "Komila";
            //user.LastName = "Usmonova";
            //user.Age = 20;
            //user.Email = "komilaqiz@gmail.com";
            //user.Password = "komila23456";

            //dbm.Update(user);

            // Delete All data

            //dbm.DeleteAll();

            var allUsers = dbm.GetUsers();
            foreach (var item in allUsers)
            {
                Console.WriteLine($"\nId: {item.UserId}\nFirst name: {item.FirstName}\n" +
                    $"Last name: {item.LastName}\nAge: {item.Age}\nGender: {item.Gender}");
            }

        }
    }
}