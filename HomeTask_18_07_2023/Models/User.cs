using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_18_07_2023.Models
{
    public class User 
    {                
        public int UserId { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(AddressId))]
        public int AddressId { get; set; }
        public Address Address { get; set; }    
    }
}
