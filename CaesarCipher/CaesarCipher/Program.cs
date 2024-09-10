using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main()
        {
            char[] alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

            Console.Write("ENTER A MESSAGE: ");
            string? result = Console.ReadLine();

            if (result != null)
            {
                char[] secretMessage = result.ToLower().ToCharArray();
                char[] encryptedMessage = new char[secretMessage.Length];

                for (int i = 0; i < secretMessage.Length; i++)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(secretMessage[i].ToString(), @"\W"))
                        continue;

                    char character = secretMessage[i];
                    int currentIndex = Array.IndexOf(alphabet, character);
                    int indexUpdate = (currentIndex + 3) % alphabet.Length;
                    encryptedMessage[i] = alphabet[indexUpdate];
                }

                Console.WriteLine(String.Join("", encryptedMessage));
            }
        }
    }
}