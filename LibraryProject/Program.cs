using System;

namespace LibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = new string[5];
            while (true)
            {
                Console.WriteLine("Choose an action: add, remove, display, exit");
                string action = Console.ReadLine().ToLower();

                if (action == "add")
                {
                    AddBook(books);
                }
                else if (action == "remove")
                {
                    RemoveBook(books);
                }
                else if (action == "display")
                {
                    DisplayBooks(books);
                }
                else if (action == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid action. Please choose add, remove, display, or exit.");
                }
            }
        }

        static void AddBook(string[] books)
        {
            Console.WriteLine("Enter the title of the book to add:");
            string title = Console.ReadLine();
            for (int i = 0; i < books.Length; i++)
            {
                if (string.IsNullOrEmpty(books[i]))
                {
                    books[i] = title;
                    Console.WriteLine($"Book '{title}' added.");
                    return;
                }
            }
            Console.WriteLine("No more space to add new books.");
        }

        static void RemoveBook(string[] books)
        {
            Console.WriteLine("Enter the title of the book to remove:");
            string title = Console.ReadLine();
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == title)
                {
                    books[i] = null;
                    Console.WriteLine($"Book '{title}' removed.");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        static void DisplayBooks(string[] books)
        {
            Console.WriteLine("Books in the library:");
            foreach (string book in books)
            {
                if (!string.IsNullOrEmpty(book))
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
