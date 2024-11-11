class Program
{
    
    static void Main()
    {
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Func<int, int, int> comparator = (a, b) =>
        (a % 2 == 0 && b % 2 != 0) ? -1 :
        (a % 2 != 0 && b % 2 == 0) ? 1 :
        a.CompareTo(b);

        Array.Sort<int>(array, new Comparison<int>(comparator));
        Console.WriteLine(string.Join(" ", array));
    }

}