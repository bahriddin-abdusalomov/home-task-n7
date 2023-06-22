namespace Hometask_20_06_2003
{
    internal class Program
    {
        public delegate T CurrencyChange<in T1, out T>(T1 val);

        static void Main(string[] args)
        {
            CurrencyChange currencyChange = new CurrencyChange();

            // from UZS to USD

            CurrencyChange<double, double> uzs_to_usd = currencyChange.UZS_To_USD;

            Console.WriteLine("1 so'm necha dollor: " + uzs_to_usd(1));

            // from USD to UZS

            CurrencyChange<double, double> usd_to_uzs = currencyChange.USD_To_UZS;

            Console.WriteLine("1 dollor necha so'm: " +  usd_to_uzs(1));

            // from UZS  to EUR

            CurrencyChange<double, double> uzs_to_eur = currencyChange.UZS_To_EUR;

            Console.WriteLine("1 so'm necha eur: " + uzs_to_eur(1));

            // from EUR to UZS

            CurrencyChange<double, double> eur_to_uzs = currencyChange.EUR_To_UZS;

            Console.WriteLine("1 eur necha so'm: " + eur_to_uzs(1));

            //////////////////////////////////////////////////////////////////////////////////
        }
    }
}