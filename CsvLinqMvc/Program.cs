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
            Console.WriteLine("6. Show all product names");
            Console.WriteLine("7. Find product by ID");
            Console.WriteLine("8. Exit");

            choice = Console.ReadLine();

            if (choice == "6")
            {
                controller.ShowAllProductNames ();

                continue;
            }

            if (choice == "7")
            {
                Console.WriteLine("Enter product ID : ");
                int id = int.Parse(Console.ReadLine());

                Product productFoundById = controller.FindProductById(id);

                continue;

            }

            if (choice == "8")
            {
                break;
            }

            controller.ShowProducts(choice);

        } while (choice != "8");


    }



}
