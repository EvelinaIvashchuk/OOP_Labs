
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        Action<string[]> action = arr => Console.WriteLine(string.Join("\n", arr));
        action(input);
    }
}