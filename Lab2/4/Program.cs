using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число n: ");
        int limit_upper = int.Parse(Console.ReadLine());

        GeneratingPrimes(limit_upper);
    }

    static void GeneratingPrimes(int limit_upper)
    {
        bool[] isPrime = new bool[limit_upper + 1];
        for (int i = 0; i <= limit_upper; i++)
        {
            isPrime[i] = true;
        }

        isPrime[0] = isPrime[1] = false;

        for (int current_number = 2; current_number * current_number <= limit_upper; current_number++)
        {
            if (isPrime[current_number])
            {
                Console.Write(current_number + " ");

                for (int multiple = current_number * current_number; multiple <= limit_upper; multiple += current_number)
                {
                    isPrime[multiple] = false;
                }
            }
        }

        for (int number = 2; number <= limit_upper; number++)
        {
            if (isPrime[number])
            {
                Console.Write(number + " ");
            }
        }
    }
}

