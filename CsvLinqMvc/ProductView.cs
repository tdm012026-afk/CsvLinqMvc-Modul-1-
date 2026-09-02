using System;
using System.Collections.Generic;
using System.Text;

namespace CsvLinqMvc
{
    public class ProductView
    {
        public void ShowProducts(List<Product> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Product: {item.Name}, Price {item.Price}");
            }
        }
    }
}
