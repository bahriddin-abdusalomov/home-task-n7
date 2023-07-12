using HomeTask_10_07_2023.Models;
using Npgsql;
using System.Globalization;

namespace HomeTask_10_07_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionDb = "Server = localhost;" +
                "Port = 5432;" +
                "User Id = postgres;" +
                "Password = salom;" +
                "Database = Users;";

            using (var connection = new NpgsqlConnection(connectionDb))
            {
                connection.Open();

                // Read data 
            //    ReadData(connection);

                User user = new User()
                {
                    Id = 32,
                    First_name = "Jasurbek",
                    Last_name = "Ubaydullayev",
                    Age = 20,
                    Email = "Jasuru@gmail.com",
                    Password = "password123456regiufewugfwbugefewofwoknlwef7",
                };

                // Write data
            //    WriteData(connection, user);

                // Sorted users by age
                SortedByAge(connection);
            }

        }

        private static void SortedByAge(NpgsqlConnection connection)
        {
            string sortedQuery = "Select * from users Order By age;";
            using(var command = new NpgsqlCommand(sortedQuery, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string first_name = reader.GetString(1);
                        string last_name = reader.GetString(2);
                        int age = reader.GetInt32(3);
                        string email = reader.GetString(4);
                        string password = reader.GetString(5);

                        Console.WriteLine($"{id} {first_name} {last_name} {age} {email}  {password}");
                    }
                }
            }
        }

        private static void WriteData(NpgsqlConnection connection, User user)
        {
            string insertQuery = "Insert into users(id, first_name, last_name, age, email, password) values(@Id, @First_name, @Last_name, @Age, @Email, @Password);";
            using (var command = new NpgsqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("id", user.Id);
                command.Parameters.AddWithValue("@First_name", user.First_name);
                command.Parameters.AddWithValue("@Last_name", user.Last_name);
                command.Parameters.AddWithValue("@Age", user.Age);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.ExecuteNonQuery();
            }
        }

        private static void ReadData(NpgsqlConnection connection)
        {

            using (var command = new NpgsqlCommand("Select * from users;", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string first_name = reader.GetString(1);
                        string last_name = reader.GetString(2);
                        int age = reader.GetInt32(3);
                        string email = reader.GetString(4);
                        string password = reader.GetString(5);

                        Console.WriteLine($"{id} {first_name} {last_name} {age} {email}  {password}");

                    }
                }
            }
        }
    }
}

