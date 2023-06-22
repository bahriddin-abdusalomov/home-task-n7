using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16_06_2023
{
    public class Square : Shape
    {
        public double Side { get ; set; }

        public override double Length()
        {
            double length = 4 * Side;
            return length;
        }

        public override double Surface()
        {
            double surface = Side * Side;
            return surface;
        }
        

    }
}
