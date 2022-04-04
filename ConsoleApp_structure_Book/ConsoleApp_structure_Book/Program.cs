
//using ConsoleApp_structure_Book.Class1;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Book Structure !");
bool continueLoop = true;
while (continueLoop)
{
    Console.WriteLine("Enter the ID of the Book:");

    ConsoleApp_structure_Book.BOOK c1 = new ConsoleApp_structure_Book.BOOK(); //Fully Qualified struct Name
    
    c1.bookID = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Title of the Book:");
    c1.Title = Console.ReadLine();
    Console.WriteLine("Enter the price of the Book:");
    c1.price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the type of Book\n\n");
    Console.WriteLine("Press 1 for Magazine\nPress 2 for Novel\nPress 3 for Reference Book\nPress 4 for Miscellaneous\n");
    int choice = Convert.ToInt32(Console.ReadLine());

    void displayDetails()
    {
        Console.WriteLine("Book ID: {0}", c1.bookID);
        Console.WriteLine("Book Title: {0}", c1.Title);
        Console.WriteLine("Book Price: {0}", c1.price);
        Console.WriteLine("---Book Type---");
        if (choice == 1)
        {
            Console.WriteLine(ConsoleApp_structure_Book.BOOK.bookType.Magazine);
        }
        else if (choice == 2)
        {
            Console.WriteLine(ConsoleApp_structure_Book.BOOK.bookType.Novel);
        }
        else if (choice == 3)
        {
            Console.WriteLine(ConsoleApp_structure_Book.BOOK.bookType.ReferenceBook);
        }
        else
        {
            Console.WriteLine(ConsoleApp_structure_Book.BOOK.bookType.Miscellaneous);
        }
    }
    displayDetails();
    Console.WriteLine("Press 0 to EXIT Program.\nPress 1 to Continue.");
    string s=Console.ReadLine();
    if (s == "0")
        continueLoop = false;
}



