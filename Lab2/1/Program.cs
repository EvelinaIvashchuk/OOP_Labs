using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перший рядок:");
        string[] array1 = Console.ReadLine().Split(' ');

        Console.WriteLine("Введіть другий рядок:");
        string[] array2 = Console.ReadLine().Split(' ');

        int end_left = end_find(array1, array2, true, out string[] words_left);
        int end_right = end_find(array1, array2, false, out string[] words_right);

        if (end_left > end_right)
        {
            Console.WriteLine($"Найбільший спільний кінець є ліворуч і складає {end_left} елементи(ів).");
            Console.WriteLine("Спільні слова: " + string.Join(" ", words_left));
        }
        else if (end_right > end_left)
        {
            Console.WriteLine($"Найбільший спільний кінець є праворуч і складає {end_right} елементи(ів).");
            Console.WriteLine("Спільні слова: " + string.Join(" ", words_right));
        }
        else if (end_left == 0)
        {
            Console.WriteLine("Немає спільних слів зліва та справа.");
        }
        else
        {
            Console.WriteLine($"Найбільший спільний кінець має однакову довжину ({end_left}) як ліворуч, так і праворуч.");
            Console.WriteLine("Спільні слова ліворуч: " + string.Join(" ", words_left));
            Console.WriteLine("Спільні слова праворуч: " + string.Join(" ", words_right));
        }
    }

    static int end_find(string[] arr1, string[] arr2, bool left, out string[] words_common)
    {
        int count_common = 0;
        int length = Math.Min(arr1.Length, arr2.Length);
        words_common = new string[length];

        for (int i = 0; i < length; i++)
        {
            if (left)
            {
                if (arr1[i] == arr2[i])
                {
                    words_common[count_common] = arr1[i];
                    count_common++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    words_common[count_common] = arr1[arr1.Length - 1 - i];
                    count_common++;
                }
                else
                {
                    break;
                }
            }
        }

        Array.Resize(ref words_common, count_common);
        return count_common;
    }
}


