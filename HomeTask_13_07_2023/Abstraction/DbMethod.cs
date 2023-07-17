using HomeTask_13_07_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_13_07_2023.Abstraction
{
    public abstract class DbMethod
    {
        public abstract void Add(User user);
        public abstract void AddRange(List<User> users);
        public abstract void Update(User user);
        public abstract void Delete(User user);
        public abstract void DeleteAll();
        public abstract IEnumerable<User> GetUsers();
    }
}
