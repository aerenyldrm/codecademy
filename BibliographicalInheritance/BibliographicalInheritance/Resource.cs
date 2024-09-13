using System;
using System.Collections.Generic;

namespace BibliographicalInheritance
{
    class Resource
    {
        // PROPERTY
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Status { get; protected set; }
        public List<string> Hold { get; protected set; }

        // CONSTRUCTOR
        public Resource(string title, string category)
        {
            Title = title;
            Category = category;
            Status = "Available";
            Hold = new List<string>();
        }

        // METHOD
        public virtual void UpdateStatus()
        {
            Status = Status == "Available" ? "Out" : "Available";
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"TITLE: {Title}\nCATEGORY: {Category}\nSTATUS: {Status}");

            if (Hold.Count != 0)
            {
                Console.Write("HOLD: ");
                foreach (string wait in Hold)
                    Console.Write($"{wait} ");
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        public void AddHold(string name)
        {
            Hold.Add(name);
        }

        public void RemoveHold(string name)
        {
            if (Hold.IndexOf(name) != -1)
                Hold.Remove(name);
        }
    }
}
