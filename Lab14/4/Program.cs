class Program
{
    static void Main()
    {
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var start = array[0];
        var end = array[1];

        var target = Console.ReadLine();

        Predicate<int> predicate;

        switch(target)
        {
            case "odd":
                {
                    predicate = n => n % 2 != 0;
                    break;
                }
            case "even":
                {
                    predicate = n => n % 2 == 0;
                    break;
                }
            default:
                predicate = null;
                break;
        }

        var result = MovingArray(start, end, predicate);
        Console.WriteLine(string.Join(" ", result));

    }

    static List<int> MovingArray(int lowerBound, int upperBound, Predicate<int> filter)
    {
        var numbers = new List<int>();

        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (filter(i))
            {
                numbers.Add(i);
            }
        }

        return numbers;
    }
}