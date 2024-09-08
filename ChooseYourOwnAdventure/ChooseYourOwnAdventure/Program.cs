using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NAME: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"GREETINGS FROM STORY, {name}.");

            Console.WriteLine("NOISE CHOICE.");
            Console.Write("TYPE 'YES' OR 'NO': ");
            string? noiseChoice = Console.ReadLine();

            if (noiseChoice != null) noiseChoice = noiseChoice.ToUpper();

            if (noiseChoice == "NO") Console.WriteLine("THE END.");
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("DOOR CHOICE.");
                Console.Write("TYPE 'OPEN' OR 'KNOCK': ");
                string? doorChoice = Console.ReadLine();

                if (doorChoice != null) doorChoice = doorChoice.ToUpper();

                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("RIDDLE ANSWER.");
                    Console.Write("TYPE ANSWER: ");
                    string? riddleAnswer = Console.ReadLine();

                    if(riddleAnswer != null) riddleAnswer = riddleAnswer.ToUpper();

                    if (riddleAnswer == "NOTHING") Console.WriteLine("THE END.");
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("KEY CHOICE.");
                    Console.Write("ENTER A NUMBER (1 - 3): ");
                    string? keyChoice = Console.ReadLine();

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("SUCCESS!");
                            Console.WriteLine("THE END.");
                            break;
                        case "2":
                            Console.WriteLine("THE END.");
                            break;
                        case "3":
                            Console.WriteLine("THE END.");
                            break;
                    }
                }
            }
        }
    }
}