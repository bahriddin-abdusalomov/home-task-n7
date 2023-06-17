using HomeTask_14_06_2023.Models;
using HomeTask_14_06_2023.Services;

namespace HomeTask_14_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KuyovBola kuyov = new KuyovBola();

            Console.Write("Bolani ismini kiriting: ");
            kuyov.Name = Console.ReadLine();

            KelinBola kelin = new KelinBola();

            Console.Write("Qizni ismini kiriting: ");
            kelin.Name = Console.ReadLine();

            Console.Write("Qiz bolaga yoqsa 1 eks holda 0 kiriting: ");
            kuyov.Fikri = bool.Parse(Console.ReadLine());

            Console.Write("Bola qizga yoqsa 1 eks holda 0 kiriting: ");
            kelin.Fikri = bool.Parse(Console.ReadLine());

            Uchrashuv.BirinchiUchrashuv(kuyov, kelin);

        }
    }
}