using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_20_06_2003
{
    public class CurrencyChange : CurrencyType
    {
        public override double EUR_To_UZS(double value)
        {
            return (value * 12526.9);
        }

        public override double JPY_To_UZS(double value)
        {
            return (value * 81.126);
        }

        public override double RUB_To_UZS(double value)
        {
            return (value * 137.132);
        }

        public override double USD_To_UZS(double value)
        {
            return (value * 11503);
        }

        public override double UZS_To_EUR(double value)
        {
            return (value * 1 / 12526.9);
        }

        public override double UZS_To_JPY(double value)
        {
            return (value * 1 / 81.126);
        }

        public override double UZS_To_RUB(double value)
        {
            return (value * 1 / 137.132);
        }

        public override double UZS_To_USD(double value)
        {
            return (value * 0.000086931);
        }
    }
}
