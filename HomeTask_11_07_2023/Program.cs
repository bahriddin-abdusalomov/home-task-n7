using HomeTask_11_07_2023.DbMethods;
using HomeTask_11_07_2023.Models;
using Npgsql;

namespace HomeTask_11_07_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server = localhost;" +
                "port = 5432;" +
                "user id = postgres;" +
                "password = salom;" +
                "database = Users;";

            using(var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                User user = new User()
                {
                        Id = 32,
                        First_name = "Ibratjon",
                        Last_name = "Ibrohimov",
                        Age = 19,
                        Email = "ibrohimovibrat@gamil.com",
                        Password = "passcas3498563swordfjkngsfjgfddfbdsdfbf",
                };

                DbMethod method = new DbMethod();

                // Insert values at table
                //    method.Add(connection, user);

                User user2 = new User()
                {
                    Id = 10,
                    First_name = "Jamshid",
                    Last_name = "Bardiqulov",
                    Age = 20,
                    Email = "jama@gmail.com",
                    Password = "jingalaknimadurkimdurkimlardir",
                };

                // Update the data in the table
                //method.Update(connection, user2);


                User user3 = new User()
                {
                    Id = 11
                };

                // Delete values from users table
                //method.Delete(connection, user3);

                method.Show(connection);
            }

        }
    }
}