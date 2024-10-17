using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введіть перший масив символів (розділені пробілами):");
        char[] array_one = Console.ReadLine().Replace(" ", "").ToCharArray();


        Console.WriteLine("Введіть другий масив символів (розділені пробілами):");
        char[] array_two = Console.ReadLine().Replace(" ", "").ToCharArray();

        arrays_compare(array_one, array_two);
    }

    static void arrays_compare(char[] array_one, char[] array_two)
    {
        string string_one = new string(array_one);
        string string_two = new string(array_two);

        int result = array_char_compare(array_one, array_two);

        if (result < 0)
        {
            Console.WriteLine(string_one);
            Console.WriteLine(string_two);
        }
        else if (result > 0)
        {
            Console.WriteLine(string_two);
            Console.WriteLine(string_one);
        }
        else
        {
            Console.WriteLine(string_one);
            Console.WriteLine(string_two);
        }
    }

    static int array_char_compare(char[] array_one, char[] array_two)
    {
        int length_one = array_one.Length;
        int length_two = array_two.Length;
        int length_min = Math.Min(length_one, length_two);

        for (int i = 0; i < length_min; i++)
        {
            if (array_one[i] < array_two[i])
                return -1;
            else if (array_one[i] > array_two[i])
                return 1;
        }

        if (length_one < length_two)
            return -1;
        else if (length_one > length_two)
            return 1;
        else
            return 0;
    }
}
