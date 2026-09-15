using CsvLinqMvc;
class Program
{
    static void Main()
    {
        var controller = new ProductController();

        string choice;

        do
        {

            Console.WriteLine("1. Show expensive products");
            Console.WriteLine("2. Show names of expensive products");
            Console.WriteLine("3. Show all products descriptions");
            Console.WriteLine("4. Show products sorted by price");
            Console.WriteLine("5. Show products sorted by price descending");
            Console.WriteLine("6. Exit");
       
            choice = Console.ReadLine();

            if (choice == "6")
            {
                break;
            }

            controller.ShowProducts(choice);

        } while (choice != "6");
        

    }

        

}
