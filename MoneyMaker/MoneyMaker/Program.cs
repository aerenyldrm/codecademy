using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("GREETINGS FROM MONEY MAKER!");
            Console.Write("ENTER AMOUNT TO CONVERT: ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{userInput} CENTS IS EQUAL TO...");

            int quarters = 25;
            int quartersCoins = (int) userInput / quarters;
            int remainder = (int) userInput % quarters;

            int dimes = 10;
            int dimesCoins = remainder / dimes;
            remainder = remainder % dimes;

            int nickels = 5;
            int nickelsCoins =  remainder / nickels;
            remainder = remainder % nickels;

            Console.WriteLine($"QUARTERS COINS: {quartersCoins}");
            Console.WriteLine($"DIMES COINS: {dimesCoins}");
            Console.WriteLine($"NICKELS COINS: {nickelsCoins}");
            Console.WriteLine($"PENNIES COINS: {remainder}");
        }
    }
}
