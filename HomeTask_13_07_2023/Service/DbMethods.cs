using HomeTask_13_07_2023.Abstraction;
using HomeTask_13_07_2023.Data;
using HomeTask_13_07_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_13_07_2023.Service
{
    public class DbMethods : DbMethod
    {
        public override void Add(User user)
        {
            var db = new AppDbContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public override void AddRange(List<User> users)
        {
            var db = new AppDbContext();
            db.Users.AddRange(users);
            db.SaveChanges();
        }

        public override void Delete(User user)
        {
            var db = new AppDbContext();
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public override void DeleteAll()
        {
            var db = new AppDbContext();
            var rows = db.Users.ToList();
            
            foreach (var row in rows)
            {
                db.Users.Remove(row);
            }
            db.SaveChanges();
        }

        public override List<User> GetUsers()
        {
            var db = new AppDbContext();
            var users = db.Users.ToList();
            return users;
        }

        public override void Update(User user)
        {
            var db = new AppDbContext();
            db.Users.Update(user);
            db.SaveChanges();
        }
    }
}
