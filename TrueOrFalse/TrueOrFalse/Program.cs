using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Greetings from 'True or False?'\n");
            Thread.Sleep(1000);

            string[] questions = ["2 * 3 = 6", "3 + 5 = 15", "12 / 6 = 2", "5 - 7 = 11", "11 + 13 = 24"];
            bool[] answers = [true, false, true, false, true];
            bool[] responses = new bool[questions.Length];

            int questionIndex = 0;
            foreach (string question in questions)
            {
                Console.WriteLine(question);

                bool isBool = false;
                bool inputBool = false;

                do
                {
                    Console.Write("True or false: ");
                    string? input = Console.ReadLine();

                    if (input != null)
                    {
                        input = input.Trim().ToLower();

                        if (input == "true" || input == "false")
                        {
                            isBool = true;

                            if (input == "true") inputBool = true;
                        }
                    }
                } while (isBool == false);

                responses[questionIndex] = inputBool;
                questionIndex++;
            }

            int scoreIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool capture = responses[scoreIndex];
                Console.WriteLine($"Input: {capture} | Answer: {answer}");

                if (capture == answer) score++;

                scoreIndex++;
            }

            Console.WriteLine($"{score} / {scoreIndex} correct!");
        }
    }
}
