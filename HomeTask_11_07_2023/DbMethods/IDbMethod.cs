
using HomeTask_11_07_2023.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_07_2023.DbMethods
{
    public interface IDbMethod
    {
        public void Add(NpgsqlConnection val1, User val2);
        public void Update(NpgsqlConnection val, User user);
        public void Delete(NpgsqlConnection val, User user);

    }
}
