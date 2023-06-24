using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_22_06_2023
{
    public class Products
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public Products(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return $"\nProduct name: {ProductName}" +
                $"\nPrice: {Price}\n";
        }
    }
}
