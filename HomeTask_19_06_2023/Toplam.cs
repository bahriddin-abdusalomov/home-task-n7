using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_19_06_2023
{
    public class Toplam<T>
    {
        private List<T> _number = new List<T>();

        public T this[int index]
        {
            get
            {
                return _number[index];
            }
            set
            {
                _number[index] = value;
            }
        }

        public void Qosh(T value)
        {
            _number.Add(value);
        }

        public void Ochir(T value)
        {
            _number.Remove(value);
        }

        public  int Soni
        {
            get { return _number.Count; }
        }

    }
}
