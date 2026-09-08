using System;
using System.Collections.Generic;
using System.Text;

namespace CsvLinqMvc
{
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct()
        {
            var product = new Product();

            product.Id = 1;
            product.Name = "Laptop";
            product.Price = 12000;

            _products.Add(product);

            var product2 = new Product();

            product2.Id = 2;
            product2.Name = "Keyboard";
            product2.Price = 500;

            _products.Add(product2);

            var product3 = new Product();

            product3.Id = 3;
            product3.Name = "Mouse";
            product3.Price = 250;

            _products.Add(product3);
            

        }
        public List<Product> GetProducts()
        {
            return _products;
        }
    }
   
}
