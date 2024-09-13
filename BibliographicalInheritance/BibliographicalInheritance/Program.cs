using System;

namespace BibliographicalInheritance
{
    class Program
    {
        static void Main()
        {
            Resource test = new("LOTR", "Sci-Fi / Fantasy");
            test.UpdateStatus();
            test.GetInfo();

            Book book = new("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", ["Charles Petzold"], 396);
            book.UpdateStatus();
            book.AddHold("Arif Eren YILDIRIM");
            book.GetInfo();

            Periodical p = new("Wired", "Technology", "Monthly");
            p.UpdateStatus();
            p.GetInfo();

            Video v = new("Ex Machina", "Alex Garland", "Sci-Fi", 108, "On-demand");
            v.GetInfo();
        }
    }
}