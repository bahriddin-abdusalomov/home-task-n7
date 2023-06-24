using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_22_06_2023
{
    public class Uzcard : Card
    {
        public override double Bonus { get; } = 5;

        public Uzcard(string number, string holderName, double money) : base(number, holderName, money)
        {
        }

        public override bool Pay(double cost)
        {
            if(Money - cost < 0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true; 
            }
        }
    }
}
