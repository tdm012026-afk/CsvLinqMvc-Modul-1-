using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CsvLinqMvc 
{
    internal class ProductReader
    {
        public List<Product> ReadProducts()
        {
            var productList = new List<Product>();
            var lines = File.ReadAllLines("cereal.csv");
            

            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');
                
                var product = new Product();
                
                product.Name = parts[0];
                product.Mfr = parts[1];
                product.Type = parts[2];
                product.Calories = int.Parse(parts[3]);
                product.Protein = double.Parse(parts[4], CultureInfo.InvariantCulture);
                product.Fat = double.Parse(parts[5], CultureInfo.InvariantCulture);
                product.Sodium = double.Parse(parts[6], CultureInfo.InvariantCulture);
                product.Fiber = double.Parse(parts[7], CultureInfo.InvariantCulture);
                product.Carbo = double.Parse(parts[8], CultureInfo.InvariantCulture);
                product.Sugars = double.Parse(parts[9], CultureInfo.InvariantCulture);
                product.Potass = double.Parse(parts[10], CultureInfo.InvariantCulture);
                product.Vitamins = double.Parse(parts[11], CultureInfo.InvariantCulture);
                product.Shelf = int.Parse(parts[12]);
                product.Weight = double.Parse(parts[13], CultureInfo.InvariantCulture);
                product.Cups = double.Parse(parts[14], CultureInfo.InvariantCulture);
                product.Rating = double.Parse(parts[15], CultureInfo.InvariantCulture);
                


                productList.Add(product);
            }
            return productList;
        }
        
    }
}
