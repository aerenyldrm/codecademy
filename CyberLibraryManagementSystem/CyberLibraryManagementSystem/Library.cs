using System;
using System.Collections.Generic;

namespace CyberLibraryManagementSystem
{
    class Library
    {
        // field
        private readonly List<Book> bookSet = [];

        // method
        public void AddBook(Book book)
        {
            bookSet.Add(book);
        }

        public List<Book> SearchBookByTitle(string book)
        {
            List<Book> filterBook = [];

            foreach (Book bookOfBookSet in bookSet)
            {
                if (!String.IsNullOrEmpty(bookOfBookSet.Title))
                {
                    if (bookOfBookSet.Title.Contains(book))
                        filterBook.Add(bookOfBookSet);
                }
            }

            return filterBook;
        }

        public void DisplayEntireBook()
        {
            foreach (Book book in bookSet)
                Console.WriteLine($"{book.Title}, {book.Author}.");
        }
    }
}