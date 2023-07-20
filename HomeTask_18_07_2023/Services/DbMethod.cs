using HomeTask_18_07_2023.Data;
using HomeTask_18_07_2023.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_18_07_2023.Services
{
    public class DbMethod<T> : IDbMethod<T> where T : class
    {
        DBContext db = new DBContext();


        public void Add(T tkey)
        {
            db.Set<T>().Add(tkey);
            db.SaveChanges();
        }

        public void AddRange(IEnumerable<T> items)
        {
            db.Set<T>().AddRange(items);
            db.SaveChanges();
        }

        public T Get(int key)
        {
           return db.Set<T>().Find(key);
        }

        public IEnumerable<T> GetAll()
        {
           return db.Set<T>().ToList();
        }

        public void Remove(T tkey)
        {
            db.Set<T>().Remove(tkey);
            db.SaveChanges();
        }

        public void Update(T val)
        {
            db.Set<T>().Update(val);
            db.SaveChanges();
        }
    }
}
