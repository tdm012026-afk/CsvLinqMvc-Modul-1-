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

            var products = _repository.GetProducts(); 

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
        public void ShowProducts(string choice)
        {
            var products = _repository.GetProducts();
            
            switch (choice)
            {
                case "1":
                    var expensiveProducts = products
                        .Where(product => product.Price > 1000)
                        .ToList();
                    _view.ShowProducts(expensiveProducts);

                    Console.WriteLine();
                    break;
                case "2":

                    var expensiveProductsNames = products
                        .Where(product => product.Price > 1000)
                        .Select(product => product.Name)
                        .ToList();
                    _view.ExpensiveProducts(expensiveProductsNames);

                    Console.WriteLine();

                    break;
                case "3":

                    var productDescriptions = products
                        .Select(product => $"Product : {product.Name}, Price {product.Price}")
                        .ToList();

                    _view.ShowDescriptions(productDescriptions);

                    Console.WriteLine();
                    break;

                case "4":
                    var sortedProducts = products
                        .OrderBy(product => product.Price)
                        .ToList();

                    _view.ShowProducts(sortedProducts);

                    Console.WriteLine();
                    break;

                case "5":
                    var descendedProducts = products
                        .OrderByDescending(product => product.Price)
                        .ToList();

                    _view.ShowProducts(descendedProducts);

                    Console.WriteLine();
                    break;

                 

                default:
                    Console.WriteLine("Invalid choice");
                    break;
                    

            }
        }
        public Product FindProductById(int id)
        {
            var products = _repository.GetProducts();

            var product = products.FirstOrDefault(product => product.Id == id);

            //_view.ShowOneProduct(product);

            if (product != null)
            {
                _view.ShowOneProduct(product);
            }
            else
            {
                Console.WriteLine("Product not found");
            }

            return product;
        }

        
    }
}
