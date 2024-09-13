using System;

namespace TheObjectOfYourAffection
{
    class Program
    {
        static void Main()
        {
            Profile sam = new("Sam Drakkila", 30, "New York", "USA", "he");

            sam.City = "Chicago";
            Console.WriteLine(sam.ViewProfile());
            sam.SetHobby(["listen to audiobooks and podcasts", "play sports bowling and kickball", "write a speculative fiction novel", "read advice columns"]);
        }
    }
}
