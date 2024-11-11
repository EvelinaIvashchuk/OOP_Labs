
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        Action<string[]> action = ShowMessage;
        action(input);
    }

    static void ShowMessage(string[] message)
    {
        Console.WriteLine(string.Join("\n", message.Select(n => $"Sir {n}")));
    }
}