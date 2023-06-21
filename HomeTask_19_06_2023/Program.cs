using System.Runtime;

namespace HomeTask_19_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplam<int> toplam = new Toplam<int>();

            Console.Write("Toplam elementlarini kiriting: ");

            string[] strings = Console.ReadLine().Split();
            int i = 0;

            foreach (var item in strings)
                 toplam.Qosh(int.Parse(item));


            int max = toplam[0];
            for (i = 0; i < toplam.Soni; i++)
            {
                if (toplam[i] > max) max = toplam[i];
            }

            toplam.Ochir(max);

            Console.WriteLine("Toplamning eng katta elementi ochirildi.. ");

            for (i = 0; i < toplam.Soni; i++)
            {
                Console.Write(toplam[i] + " ");
            }

            Console.WriteLine();
        }
    }
}