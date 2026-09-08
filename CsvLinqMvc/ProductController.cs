using System;
using System.Collections.Generic;
using System.Text;

namespace CsvLinqMvc
{
    public class ProductController
    {
        public ProductRepository _repository;
        public ProductView _view;
 
        public ProductController()
        {
            _repository = new ProductRepository();
            _view = new ProductView();
        }
        public void ShowProducts()
        {
            var products = _repository.GetProducts();
            _repository.AddProduct();

            _view.ShowProducts(products);    
        }
        
    }
}
