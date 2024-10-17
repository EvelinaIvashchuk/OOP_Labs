using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть послідовність чисел:");
        string[] inputLine = Console.ReadLine().Split(' ');

        int[] arr = Array.ConvertAll(inputLine, int.Parse);

        Console.WriteLine("Введіть значення різниці:");
        int k = int.Parse(Console.ReadLine());
        var pairs = FindPairsWithDiffK(arr, k);
        if (pairs.Count > 0)
        {
            Console.WriteLine($"Кількість пар з різницею {k} -> {pairs.Count}.");
            Console.WriteLine($"Пари елементів з різницею {k}:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{{{pair.Item1}, {pair.Item2}}}");
            }
        }
        else
        {
            Console.WriteLine($"Немає пар з різницею {k}.");
        }
    }
    static List<Tuple<int, int>> FindPairsWithDiffK(int[] arr, int k)
    {
        var pairs = new List<Tuple<int, int>>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) == k)
                {
                    pairs.Add(Tuple.Create(arr[i], arr[j]));
                }
            }
        }

        return pairs;
    }
}
