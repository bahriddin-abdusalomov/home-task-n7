using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_22_06_2023
{
    public class Humo : Card
    {
        public Humo(string number, string holderName, double money) : base(number, holderName, money)
        {
        }

        public override bool Pay(double cost)
        {
            if (Money - cost < 0)
            {
                return false;
            }

            Money -= cost;
            return true;
        }

        public bool PayWireless(double cost)
        {
            if (cost > 50000 || Money - cost < 0)
            {
                return false;
            }

            Money -= cost;
            return true;
        }
    }
}
