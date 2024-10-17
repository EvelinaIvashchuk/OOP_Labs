using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введіть масив із 4*k чисел (через пробіл):");
        string input = Console.ReadLine();
        int[] numbers;

        try
        {
            numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            if (numbers.Length % 4 != 0)
            {
                Console.WriteLine("Масив має містити кількість елементів, кратну 4.");
                return;
            }

            int count_blocks = numbers.Length / 4;
            int[] row_one = new int[2 * count_blocks];
            for (int i = 0; i < count_blocks; i++)
            {
                row_one[i] = numbers[count_blocks - 1 - i];                
                row_one[count_blocks + i] = numbers[numbers.Length - 1 - i]; 
            }
            int[] row_two = new int[2 * count_blocks];
            Array.Copy(numbers, count_blocks, row_two, 0, 2 * count_blocks);
            Console.WriteLine("Перший рядок після згинання:");
            Console.WriteLine(string.Join(" ", row_one));

            Console.WriteLine("Другий рядок після згинання:");
            Console.WriteLine(string.Join(" ", row_two));

            int[] sumRows = new int[2 * count_blocks];
            for (int i = 0; i < 2 * count_blocks; i++)
            {
                sumRows[i] = row_one[i] + row_two[i];
            }
            Console.WriteLine("Результат складання:");
            Console.WriteLine(string.Join(" ", sumRows));
            int row_one_sum = 0, row_two_sum = 0;
            foreach (int number in row_one)
            {
                row_one_sum += number;
            }
            foreach (int number in row_two)
            {
                row_two_sum += number;
            }

            Console.WriteLine($"Сума першого рядка: {row_one_sum}");
            Console.WriteLine($"Сума другого рядка: {row_two_sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неправильний формат введення. Переконайтеся, що ви вводите лише числові значення.");
        }
    }
}
