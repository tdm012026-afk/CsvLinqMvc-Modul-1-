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
        
        public void ShowProducts(string choice)
        {
            var products = _repository.GetProducts();
            
            switch (choice)
            {
                case "1":
                    var highCaloriesProducts = products
                        .Where(product => product.Calories > 100)
                        .ToList();
                    _view.ShowProducts(highCaloriesProducts);

                    Console.WriteLine();
                    break;
                case "2":

                    var sugarRichProducts = products
                        .Where(product => product.Sugars > 10)
                        .Select(product => product.Name)
                        .ToList();
                    _view.ShowSugarRichProducts(sugarRichProducts);

                    Console.WriteLine();

                    break;
                case "3":

                    var productDescriptions = products
                        .Select(product => $"Product : {product.Name}, {product.Calories}, {product.Rating}")
                        .ToList();

                    _view.ShowDescriptions(productDescriptions);

                    Console.WriteLine();
                    break;


                case "4":
                    var sortedProducts = products
                        .OrderBy(product => product.Calories)
                        .ToList();

                    _view.ShowProducts(sortedProducts);

                    Console.WriteLine();
                    break;

                case "5":
                    var descendedProducts = products
                        .OrderByDescending(product => product.Rating)
                        .ToList();

                    _view.ShowProducts(descendedProducts);

                    Console.WriteLine();
                    break;

                 

                default:
                    Console.WriteLine("Invalid choice");
                    break;
                    

            }
        }
        
        public void ShowAllProductNames()
        {
            var products = _repository.GetProducts();

            var productNames = products
                .Select(product => product.Name)
                .ToList();

            _view.ShowProductNames(productNames);
        }

        
    }
}
