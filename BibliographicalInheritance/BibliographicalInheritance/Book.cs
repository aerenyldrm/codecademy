using System;

namespace BibliographicalInheritance
{
    class Book : Resource
    {
        // PROPERTY
        public string[] Author { get; set; }
        public int PageCount { get; set; }

        // CONSTRUCTOR
        public Book(string title, string category, string[] author, int pageCount) : base(title, category)
        {
            Author = author;
            PageCount = pageCount;
        }
    }
}
