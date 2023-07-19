using HomeTask_13_07_2023.Data;
using HomeTask_17_07_2023.Sevices;
using Microsoft.EntityFrameworkCore;
using SeedData.Data;
using SeedData.Models;

namespace HomeTask_17_07_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GmDbContext db = new GmDbContext();

            DbMethod<Bus> busMethod = new DbMethod<Bus>();
            DbMethod<Car> carMethod = new DbMethod<Car>();
            DbMethod<Client> clientMethod = new DbMethod<Client>();

            var client = db.Clients.FirstOrDefault(x => x.Name == "Bahriddin");
            var car = db.Cars.Where(x => x.Id > 1).ToList();

            //client.Cars = car;
            //db.SaveChanges();

            var clients = db.Clients.Include(x=> x.Cars)
                .Where(x => x.Id ==  1)
                .AsNoTracking()
                .ToList();

            foreach (var item in clients)
            {
                Console.WriteLine(item.Name);
                foreach (var item1 in item.Cars)
                {
                    Console.WriteLine("-----" + item1.Id);
                    Console.WriteLine("-----" + item1.Name);
                    Console.WriteLine("-----" + item1.Speed);
                    Console.WriteLine();
                }
            }



        }
    }
}