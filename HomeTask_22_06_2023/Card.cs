using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_22_06_2023
{
    public abstract class Card
    {

        public string Number { get; set; }

        public string HolderName { get; set; }

        public double Money { get; set; }

        public virtual double Bonus { get; } = 0;

        public Card(string number, string holderName, double money)
        {
            Number = number;
            HolderName = holderName;
            Money = money;
        }
        public abstract bool Pay(double cost);

        public double Add(double amount)
        {
            Money += amount;
            return Money;
        }

        public  double AddWithBonus(double amount)
        {
            Money += amount + Bonus;
            return Money;
        }
    }
}

