using System;
using System.Collections.Generic;
using System.Text;

namespace CsvLinqMvc
{
    internal class ProductReader
    {
        public List<Product> ReadProducts()
        {
            var productList = new List<Product>();
            var lines = File.ReadAllLines("Products.csv");
            

            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');
                
                var product = new Product();
                
                product.Id = int.Parse(parts[0]);
                product.Name = parts[1];
                product.Price = decimal.Parse(parts[2]);

                productList.Add(product);
            }
            return productList;
        }
    }
}
