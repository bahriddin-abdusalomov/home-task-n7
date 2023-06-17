using HomeTask_14_06_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_14_06_2023.Services
{
    public static class Uchrashuv
    {
        public static void BirinchiUchrashuv(KuyovBola kuyov, KelinBola kelin)
        {
            if (kuyov.Fikri == true && kelin.Fikri == true)
            {
                Console.WriteLine($"{kuyov.Name}jon va {kelin.Name}xon to'ylar muborak bo'lsin");
            }
            else
            {
                Console.WriteLine("Chuchvara atmen :)");
            }
        }
    }
}
