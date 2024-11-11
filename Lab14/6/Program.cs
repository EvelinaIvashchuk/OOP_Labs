class Program
{
    static void Main()
    {
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var divisor = int.Parse(Console.ReadLine());

        Func<int, bool> filter = n => n % divisor != 0;
        var remainingNumbers = array.Reverse().Where(filter);
        Console.WriteLine(string.Join(" ", remainingNumbers));
    }
}