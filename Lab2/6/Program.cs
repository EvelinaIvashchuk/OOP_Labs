using System;

namespace LongestEqualSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть масив чисел (розділених пробілами):");
            string input = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Помилка: масив чисел не може бути порожнім або містити тільки пробіли.");
                return;
            }


            string[] inputParts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers;

            try
            {
                numbers = Array.ConvertAll(inputParts, int.Parse);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введення повинно містити лише цілі числа, розділені пробілами.");
                return;
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("Масив порожній.");
                return;
            }

            int start = 0;
            int bestLen = 1;
            int current_start = 0;
            int current_length = 1;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    current_length++;
                }
                else
                {
                    if (current_length > bestLen)
                    {
                        bestLen = current_length;
                        start = current_start;
                    }

                    current_start = i;
                    current_length = 1;
                }
            }

            if (current_length > bestLen)
            {
                bestLen = current_length;
                start = current_start;
            }

            Console.WriteLine("Найдовша послідовність однакових елементів:");
            for (int i = start; i < start + bestLen; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
