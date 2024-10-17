using System;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть масив чисел (розділених пробілами):");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            int longest_start = 0;
            int longest_length = 0;
            int start_current = 0;
            int length_current = 1;

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] > numbers[i - 1])
                {
                    length_current++;
                }
                else
                {
                    if (length_current > longest_length)
                    {
                        longest_start = start_current;
                        longest_length = length_current;
                    }

                    start_current = i;
                    length_current = 1;
                }
            }

            if (length_current > longest_length)
            {
                longest_start = start_current;
                longest_length = length_current;
            }


            Console.WriteLine("Найдовша зростаюча підпослідовність:");
            for (int i = longest_start; i < longest_start + longest_length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

