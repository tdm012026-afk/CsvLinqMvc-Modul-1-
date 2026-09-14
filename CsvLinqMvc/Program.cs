using CsvLinqMvc;
class Program
{
    static void Main()
    {
        var controller = new ProductController();

        Console.WriteLine("1. Show expensive products");
        Console.WriteLine("2. Show names of expensive products");
        Console.WriteLine("3. Show all products descriptions");
        Console.WriteLine("4. Show products sorted by price");
        Console.WriteLine("5. Show products sorted by price descending");

        string choice = Console.ReadLine();

        controller.ShowProducts(choice);


    }

        

}
