using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_14_06_2023.Models
{
    public class KuyovBola
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Fikri { get; set; }



        public KuyovBola()
        {

        }

        public KuyovBola(string name, int age, bool fikri)
        {
            Name = name;
            Age = age;
            Fikri = fikri;
        }
    }
}
