class Program
{
    static void Main()
    {
        Console.Write("1...");
        int end = int.Parse(Console.ReadLine());
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var predicates = array.Select(arr => (Func<int, bool>)(n => n % arr == 0)).ToArray();

        List<int> list = new List<int>();

        for(int i = 1; i <= end; i++)
        {
            if(IsValid(predicates, i))
            {
                list.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", list));

    }

    static bool IsValid(Func<int, bool>[] predicates, int num)
    {
        foreach (var predicate in predicates)
        {
            if (!predicate(num))
            {
                return false;
            }
        }

        return true;
    }
}