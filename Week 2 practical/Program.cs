using Week_2_practical;
class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        books.Add(new Book("C# for beginners", "Bill Gates", "1234567"));
        books.Add(new Book("Ultimate C#", "Microsoft", "2233445"));

        // Create new instances of the Member class
        // These new members are created using the
        // Member constructor in the Members class
        members.Add(new Member(1, "John Smith", "1 High Street", "0790090090"));
        members.Add(new Member(2, "Mary Jones", "102 Garden Road", "0790345666"));

        foreach (Book book in books)
        {
            book.DisplayInfo();
        }
        foreach (Member member in members)
        {
            member.DisplayInfo();
        }
        Dictionary<string, int> bookInventory = new Dictionary<string, int>();


        // Add our two sample books to the inventory (ISBN, Quantity)
        bookInventory.Add("1234567", 5);
        bookInventory.Add("2233445", 2);


        // Display the inventory for a specific book using its ISBN key
        Console.WriteLine($"Copies of 'C# for beginners' in stock: {bookInventory["1234567"]}");
        Console.WriteLine("Checking inventory for a missing book...");

        try
        {
            // This ISBN does not exist, so it will throw a KeyNotFoundException
            Console.WriteLine(bookInventory["9999999"]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: That ISBN was not found in the inventory system.");
        }
        finally
        {
            Console.WriteLine("Inventory check complete.");
        }
    }
}