using System;
using System.Collections.Generic;
using System.Text;

namespace CsvLinqMvc
{
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>();
        private ProductReader _reader;
        
        public ProductRepository()
        {
            _reader = new ProductReader();
            _products = _reader.ReadProducts();
        }

      
        public List<Product> GetProducts()
        {
            return _products;
        }
        
        
        
    }
   
}
