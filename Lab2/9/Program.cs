using System;

namespace AlphabetIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            Console.Write("Введіть слово: ");
            string inputWord = Console.ReadLine();

            foreach (char letter in inputWord)
            {
                if (char.IsLower(letter))
                {
                    int index = Array.IndexOf(alphabet, letter);
                    Console.WriteLine($"{letter} -> {index}");
                }
                else
                {
                    Console.WriteLine($"{letter} не є маленькою літерою");
                }
            }
        }
    }
}
