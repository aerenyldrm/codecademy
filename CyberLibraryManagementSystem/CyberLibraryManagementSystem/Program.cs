using System;
using System.Collections.Generic;

namespace CyberLibraryManagementSystem
{
    class Program
    {
        static void Main()
        {
            Library library = new Library();

            Book book1 = new()
            {
                Title = "1984",
                Author = "George Orwell"
            };

            Book book2 = new()
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee"
            };

            library.AddBook(book1);
            library.AddBook(book2);

            List<Book> result = library.SearchBookByTitle("1984");

            foreach (Book component in result)
                Console.WriteLine($"{component.Title}, {component.Author}.");

            Console.WriteLine(); // line break;

            library.DisplayEntireBook();
        }
    }
}