using System;
using System.Collections.Generic;
using System.Text;

namespace CsvLinqMvc
{
    public class ProductController
    {
        private ProductRepository _repository;
        private ProductView _view;
        private ProductReader _reader;
 
        public ProductController()
        {
            _repository = new ProductRepository();
            _view = new ProductView();
            _reader = new ProductReader();
        }
        public void ShowProducts()
        {
            //_repository.AddProduct();

            //var products = _repository.GetProducts();

            var products = _reader.ReadProducts();
            Console.WriteLine($"Loaded products: {products.Count}");
           
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

            var productDescriptions = products
                .Select(product => $"Product : {product.Name}, Price{product.Price}")
                .ToList();

            _view.ShowDescriptions(productDescriptions);

            


        }

        
    }
}
