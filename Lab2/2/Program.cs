using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введіть масив цілих чисел (через пробіл):");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Введіть кількість обертань:");
        int k = int.Parse(Console.ReadLine());

        int[] sum = array_new_sum(array, k);
        Console.WriteLine("Сума після обертання:");
        Console.WriteLine(string.Join(" ", sum));
    }
    static int[] array_new(int[] arr, int rotations)
    {
        int n = arr.Length;
        int[] rotated = new int[n];
        for (int i = 0; i < n; i++)
        {
            rotated[(i + rotations) % n] = arr[i];
        }
        return rotated;
    }
    static int[] array_new_sum(int[] arr, int k)
    {
        int[] sum = new int[arr.Length];

        for (int i = 1; i <= k; i++)
        {
            int[] rotated = array_new(arr, i);
            for (int j = 0; j < arr.Length; j++)
            {
                sum[j] += rotated[j];
            }
        }

        return sum;
    }
}

