using HomeTask_17_07_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class Client : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Car>? Cars { get; set; }
        public ICollection<Bus>? Buss { get; set; }
    }
}
