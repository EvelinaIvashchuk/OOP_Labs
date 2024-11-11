class Program
{
    static void Main()
    {
        var comming = Console.ReadLine().Split().ToList();

        string command = null;
        while((command = Console.ReadLine()) != "Party!")
        {
            string[] input = command.Split();

            switch (input[1])
            {
                case "StartsWith":
                    ForeachName(input[0], comming, n => n.StartsWith(input[2]));
                    break;
                case "EndsWith":
                    ForeachName(input[0], comming, n => n.EndsWith(input[2]));
                    break;
                case "Length":
                    ForeachName(input[0], comming, n => n.Length == int.Parse(input[2]));
                    break;
                default:
                    break;
            }
        }

        PrintCommingList(comming);
    }

    static void PrintCommingList(List<string> comming)
    {
        if (comming.Any())
        {
            var names = string.Join(", ", comming);
            Console.WriteLine($"{names} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }

    static void ForeachName(string command, List<string> comming, Func<string, bool> condition)
    {
        for (int i = comming.Count - 1; i >= 0; i--)
        {
            if (condition(comming[i]))
            {
                switch (command)
                {
                    case "Remove":
                        comming.RemoveAt(i);
                        break;
                    case "Double":
                        comming.Add(comming[i]);
                        break;
                    default:
                        break;
                }
            }
        }
    }

}