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
                Console.WriteLine($"Product: {item.Name}, Calories {item.Calories}");
            }
        }
        public void ExpensiveProducts(List<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Product : {name}");
            }
        }
        public void ShowDescriptions(List<string> description)
        {
            foreach (var product in description)
            {
                Console.WriteLine(product);
            }
        }
        public void ShowOneProduct(Product product)
        {
            Console.WriteLine($"Product: {product.Name}, Calories {product.Calories}");
        }
        public void ShowProductNames(List<string> productNames)
        {
            foreach (var name in productNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
