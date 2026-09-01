using CsvLinqMvc;
class Program
{
    static void Main()
    {
        var product = new Product();

        product.Id = 1;
        product.Name = "Laptop";
        product.Price = 12000;

        var product2 = new Product();

        product2.Id = 2;
        product2.Name = "Keyboard";
        product2.Price = 500;
    }
}
