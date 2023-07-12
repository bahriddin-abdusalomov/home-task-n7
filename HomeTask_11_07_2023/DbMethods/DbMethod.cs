using Dapper;
using HomeTask_11_07_2023.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_07_2023.DbMethods
{
    public class DbMethod : IDbMethod
    {
        public void Add(NpgsqlConnection connection, User user)
        {
            string addQuery = "Insert into users values(@Id, @First_name, @Last_name, @Age, @Email, @Password);";
            connection.Execute(addQuery, user);
        }

        public void Delete(NpgsqlConnection connection, User user)
        {
            string deleteQuery = "Delete from users where id = @Id;";
            connection.Execute(deleteQuery, user);
        }

        public void Update(NpgsqlConnection connection, User user)
        {
            string updateQuery = "UPDATE users " +
                "SET first_name = @First_name, last_name = @Last_name, " +
                "age = @Age, email = @Email, password = @Password WHERE Id = @Id";
            connection.Execute(updateQuery, user);
        }
    }
}
