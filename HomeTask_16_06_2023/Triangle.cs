using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16_06_2023
{
    public class Triangle : Shape
    {
        public double Side_A { get; set; }

        public double Side_B { get; set;}

        public double Side_C { get; set;}

        public override double Length()
        {
            double length = Side_A + Side_B + Side_C;
            return length;
        }

        public override double Surface()
        {
            double halfLength = (Side_A + Side_B + Side_C) / 2;
            double surface = Math.Sqrt(halfLength * (halfLength - Side_A) * (halfLength - Side_B) * (halfLength - Side_C));
            return surface;
        }
    }
}
