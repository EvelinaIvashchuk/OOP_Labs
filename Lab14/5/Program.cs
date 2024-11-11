class Program
{
    static void Main()
    {
        var array = Console.ReadLine().Split().Select(int.Parse);

        string command = null;
        while ((command = Console.ReadLine()) != "end")
        {
            switch (command)
            {
                case "add":
                    {
                        array = MovementOn(array, n => n + 1);
                        break;
                    }
                case "subtract":
                    {
                        array = MovementOn(array, n => n - 1);
                        break;
                    }
                case "multiply":
                    {
                        array = MovementOn(array, n => n * 2);
                        break;
                    }
                case "print":
                    {
                        Console.WriteLine(string.Join(" ", array));
                        break;
                    }
                default:
                    command = null;
                    break;
            }
        }
    }

    static IEnumerable<int> MovementOn(IEnumerable<int> list, Func<int, int> func)
    {
        return list.Select(n => func(n));
    }
}