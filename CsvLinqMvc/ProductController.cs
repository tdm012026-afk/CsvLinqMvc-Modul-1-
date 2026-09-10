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
        {   _repository.AddProduct();

            var products = _repository.GetProducts();
           
           // _view.ShowProducts(products);    

            var expensiveProducts = products
                .Where(product => product.Price > 1000)
                .ToList();
            _view.ShowProducts(expensiveProducts);

            var expensiveProductsNames = products
                .Where(product => product.Price > 1000)
                .Select(product => product.Name)
                .ToList();
            _view.ExpensiveProducts(expensiveProductsNames);
            
        }

        
    }
}
