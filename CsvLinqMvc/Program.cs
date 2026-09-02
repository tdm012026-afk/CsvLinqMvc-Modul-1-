using CsvLinqMvc;
class Program
{
    static void Main()
    {
        var product = new Product();

        var repository = new ProductRepository();
        repository.AddProduct();
        var products = repository.GetProducts();

       
    }
        

}
