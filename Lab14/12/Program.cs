using _12;

public class Program
{
    public static void Main()
    {
        var gems = Console.ReadLine().Split().Select(int.Parse).ToList();
        CommandsType(gems);
        Console.WriteLine(string.Join(" ", gems));
    }

    static void CommandsType(List<int> gems)
    {
        var exclusionFilters = new List<Filter>();

        string forge = null;
        while ((forge = Console.ReadLine()) != "Forge")
        {
            string[] input = forge.Split(";");

            var command = input[0];
            var filterType = input[1];
            var filterParameter = int.Parse(input[2]);

            switch (command)
            {
                case "Exclude":
                    exclusionFilters.Add(new Filter(filterType, filterParameter)); 
                    break;
                case "Reverse":
                    if (exclusionFilters.Count > 0)
                    {
                        exclusionFilters.RemoveAt(exclusionFilters.Count - 1); 
                    }
                    break;
                default:
                    break;
            }
        }

        FiltersType(gems, exclusionFilters);
    }

    static void FiltersType(List<int> gems, List<Filter> exclusionFilters)
    {
        foreach (var filter in exclusionFilters.AsEnumerable().Reverse())
        {
            switch (filter.Type)
            {
                case "Sum Left":
                    Sum_Left(filter.Parameter, gems);
                    break;
                case "Sum Right":
                    Sum_Right(filter.Parameter, gems);
                    break;
                case "Sum Left Right":
                    Sum_Left_Right(filter.Parameter, gems);
                    break;
                default:
                    break;
            }
        }
    }

    static void Sum_Left_Right(int value, List<int> gems)
    {
        for (int i = 0; i < gems.Count; i++)
        {
            var leftGemPower = (i == 0) ? 0 : gems[i - 1];
            var rightGemPower = (i == gems.Count - 1) ? 0 : gems[i + 1];

            if (leftGemPower + gems[i] + rightGemPower == value)
            {
                gems.RemoveAt(i);
                i--;
            }
        }
    }

    static void Sum_Right(int value, List<int> gems)
    {
        while (gems.Count > 0 && gems.Last() == value)
        {
            gems.RemoveAt(gems.Count - 1);
        }

        for (int i = 0; i < gems.Count; i++)
        {
            var rightNum = (i == gems.Count - 1) ? 0 : gems[i + 1];

            if (gems[i] + rightNum == value)
            {
                gems.RemoveAt(i);
                i--;
            }
        }
    }

    static void Sum_Left(int value, List<int> gems)
    {
        while (gems.Count > 0 && gems.First() == value)
        {
            gems.RemoveAt(0);
        }

        for (int i = gems.Count - 1; i >= 0; i--)
        {
            var leftNum = (i > 0) ? gems[i - 1] : 0;

            if (gems[i] + leftNum == value)
            {
                gems.RemoveAt(i);
            }
        }
    }
}
