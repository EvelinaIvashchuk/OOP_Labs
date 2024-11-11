class Program
{
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split();
        Func<string, bool> func = p => p.Length <= n;
        Console.WriteLine(string.Join("\n", names.Where(func)));
    }


}