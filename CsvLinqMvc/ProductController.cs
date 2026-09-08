using System;
using System.Collections.Generic;
using System.Text;

namespace CsvLinqMvc
{
    public class ProductController
    {
        private ProductRepository _repository;
        private ProductView _view;
 
        public ProductController()
        {
            _repository = new ProductRepository();
            _view = new ProductView();
        }
        public void ShowProducts()
        {   
            _repository.AddProduct();

            var products = _repository.GetProducts();
           
            _view.ShowProducts(products);    
        }
        
    }
}
