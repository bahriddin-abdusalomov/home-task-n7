using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16_06_2023
{
    public class Circle : Shape
    {
        public const float PI = 3.14f;

        public double Radius { get ; set; }

        public override double Length()
        {
            double length = 2 * PI * Radius;
            return length;
        }

        public override double Surface()
        {
            double surface = PI * Radius * Radius;
            return surface;
        }
    }
}
