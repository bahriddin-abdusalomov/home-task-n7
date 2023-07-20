using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_18_07_2023.Interfaces
{
    public interface IDbMethod<T> where T : class
    {
       
        public T Get(int key);
        public IEnumerable<T> GetAll();
        public void Add(T tkey);
        public void AddRange(IEnumerable<T> items);
        public void Remove(T tkey);
        public void Update(T val);

    }
}
