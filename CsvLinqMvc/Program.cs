using CsvLinqMvc;
class Program
{
    static void Main()
    {
        var controller = new ProductController();

        string choice;

        do
        {

            Console.WriteLine("1. Show products with more than 100 calories");
            Console.WriteLine("2. Show names of products with more than 10 sugars");
            Console.WriteLine("3. Show products descriptions");
            Console.WriteLine("4. Show products sorted by calories");
            Console.WriteLine("5. Show products sorted by rating");
            Console.WriteLine("6. Show all product names");
            Console.WriteLine("7. Exit");

            choice = Console.ReadLine();

            if (choice == "6")
            {
                controller.ShowAllProductNames ();

                continue;
            }

            if (choice == "7")
            {
                break;
            }

            controller.ShowProducts(choice);

        } while (choice != "7");


    }



}
