using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть послідовність чисел (розділених пробілами): ");
            string input = Console.ReadLine();

            string[] array = input.Split(' ');

            var numbers = array.Select(number_string =>
            {
                int number;
                bool is_valid = int.TryParse(number_string, out number);
                return new { Number = number, IsValid = is_valid };
            }).Where(x => x.IsValid).Select(x => x.Number).ToList();


            if (numbers.Count == 0)
            {
                Console.WriteLine("Введені дані не містять чисел.");
                return;
            }


            var mostFrequent = numbers
                .GroupBy(n => n)
                .Select(g => new { Number = g.Key, Frequency = g.Count() })
                .OrderByDescending(x => x.Frequency)
                .ThenBy(x => x.Number)
                .First();



Console.WriteLine($"Число {mostFrequent.Number} зустрічається частіше за все ({mostFrequent.Frequency} разів)");
        }
    }
}

