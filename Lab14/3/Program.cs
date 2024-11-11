class Program
{
    static void Main()
    {
       var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Func<int[], int> func = s => s.Min();
        Console.WriteLine(func(array));
    }
}