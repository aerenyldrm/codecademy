using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 9;
            string uppercase = "[A-Z]";
            string lowercase = "[a-z]";
            string digits = "[0-9]";
            string specialChars = "[!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~]";

            Console.Write("ENTER A PASSWORD: ");
            string? userInput = Console.ReadLine();

            int score = 0;

            if (userInput != null)
            {
                score += userInput.Length >= minLength ? 1 : 0;
                score += Regex.IsMatch(userInput, uppercase) ? 1 : 0;
                score += Regex.IsMatch(userInput, lowercase) ? 1 : 0;
                score += Regex.IsMatch(userInput, digits) ? 1 : 0;
                score += Regex.IsMatch(userInput, specialChars) ? 1 : 0;
            }

            if (userInput == "password" || userInput == "1234")
                score = 0;

            switch (score)
            {
                case >= 4:
                    Console.WriteLine("PASSWORD IS EXTREMELY STRONG.");
                    break;
                case >= 3:
                    Console.WriteLine("PASSWORD IS STRONG.");
                    break;
                case >= 2:
                    Console.WriteLine("PASSWORD IS MEDIUM.");
                    break;
                case >= 1:
                    Console.WriteLine("PASSWORD IS WEAK.");
                    break;
                default:
                    Console.WriteLine("NONE OF PASSWORD STANDARDS ARE PROVIDED.");
                    break;
            }
        }
    }
}
