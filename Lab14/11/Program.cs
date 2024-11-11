using _11;
class Program
{
    public static void Main()
    {
        var names = Console.ReadLine().Split();
        var filters = GetFilters();
        names = FilterNames(filters, names);
        Console.WriteLine(string.Join(" ", names));
    }

    static string[] FilterNames(HashSet<Filter> filters, string[] names)
    {
        foreach (Filter filter in filters)
        {
            if (filter.Command.Contains("Starts"))
            {
                names = Filter.FilterCollection(names, n => n.StartsWith(filter.Arg));
            }
            else if (filter.Command.Contains("Ends"))
            {
                names = Filter.FilterCollection(names, n => n.EndsWith(filter.Arg));
            }
            else if (filter.Command.Contains("Length"))
            {
                names = Filter.FilterCollection(names, n => n.Length == int.Parse(filter.Arg));
            }
            else if (filter.Command.Contains("Contains"))
            {
                names = Filter.FilterCollection(names, n => n.ToLower().Contains(filter.Arg.ToLower()));
            }
        }

        return names;
    }

    static HashSet<Filter> GetFilters()
    {
        var filters = new HashSet<Filter>();

        string command = null;
        while ((command = Console.ReadLine()) != "Print")
        {
            var input = command.Split(';');
            var currentFilter = new Filter() { Command = input[1], Arg = input[2] };

            if (input[0].StartsWith("Add"))
            {
                filters.Add(currentFilter);
            }
            else if (input[0].StartsWith("Remove"))
            {
                filters.RemoveWhere(f => f.Arg == currentFilter.Arg &&f.Command == currentFilter.Command);
            }

        }

        return filters;
    }
}

   



