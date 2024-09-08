using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            THIS PROGRAM IS MadLibs.
            AUTHOR IS ARIF EREN YILDIRIM
            */

            Console.WriteLine("MadLibs IS ABOUT TO START!");
            string title = "TRANSFORM";
            Console.WriteLine(title);

            // define user input and variables
            Console.Write("ENTER A NAME: ");
            string name = Console.ReadLine();

            Console.Write("ENTER FIRST ADJECTIVE: ");
            string firstAdjective = Console.ReadLine();
            Console.Write("ENTER SECOND ADJECTIVE: ");
            string secondAdjective = Console.ReadLine();
            Console.Write("ENTER THIRD ADJECTIVE: ");
            string thirdAdjective = Console.ReadLine();

            Console.Write("ENTER A VERB: ");
            string verb = Console.ReadLine();

            Console.Write("ENTER FIRST NOUN: ");
            string firstNoun = Console.ReadLine();
            Console.Write("ENTER SECOND NOUN: ");
            string secondNoun = Console.ReadLine();

            Console.Write("ENTER AN ANIMAL: ");
            string animal = Console.ReadLine();
            Console.Write("ENTER A FOOD: ");
            string food = Console.ReadLine();
            Console.Write("ENTER A FRUIT: ");
            string fruit = Console.ReadLine();
            Console.Write("ENTER A SUPERHERO: ");
            string superhero = Console.ReadLine();
            Console.Write("ENTER A COUNTRY: ");
            string country = Console.ReadLine();
            Console.Write("ENTER A DESSERT: ");
            string dessert = Console.ReadLine();
            Console.Write("ENTER A YEAR: ");
            string year = Console.ReadLine();

            // template for story
            string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";

            // print story
            Console.WriteLine(story.ToUpper());
        }
    }
}
