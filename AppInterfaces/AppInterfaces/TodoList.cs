using System;

namespace AppInterfaces
{
    class TodoList : IDisplayable, IResetable
    {
        // IDisplayable interface property
        public string HeaderSymbol { get; set; }

        // IDisplayable interface method
        public void Display()
        {
            Console.WriteLine("TO DO:");
            Console.WriteLine(HeaderSymbol);

            if (TodoSet[0] != null)
            {
                foreach (string todoSet in TodoSet)
                {
                    if (todoSet != null)
                        Console.WriteLine(todoSet);
                }
            }
            Console.WriteLine(); // line break
        }

        // IResetable interface method
        public void Reset()
        {
            TodoSet = new string[5];
            nextOpenIndex = 0;
        }

        // instance property
        public string[] TodoSet
        { get; private set; }

        // field
        private int nextOpenIndex;

        // constructor
        public TodoList()
        {
            TodoSet = new string[5];
            HeaderSymbol = "-------";
            nextOpenIndex = 0;
        }

        // method
        public void Add(string todo)
        {
            TodoSet[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
    }
}