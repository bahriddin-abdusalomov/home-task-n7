using HomeTask_17_07_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class Car : BaseEntity
    {
        public string? Name { get; set; }
        public int Speed { get; set; }

        public ICollection<Client>? Clients { get; set; }
    }
}
