using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_20_06_2003
{
    public abstract class CurrencyType
    {
        public abstract double UZS_To_USD(double value);

        public abstract double USD_To_UZS(double value);

        public abstract double UZS_To_EUR(double value);

        public abstract double EUR_To_UZS(double value);

        public abstract double UZS_To_RUB(double value);

        public abstract double RUB_To_UZS(double value);

        public abstract double UZS_To_JPY(double value);

        public abstract double JPY_To_UZS(double value);


    }
}
