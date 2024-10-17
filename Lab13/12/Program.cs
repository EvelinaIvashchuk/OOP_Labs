using _12;

class Program
{
    static void Main()
    {
        try
        {
            List<OfficeStuff> officestuffs = new List<OfficeStuff>();
            int N = int.Parse(Console.ReadLine());
            if (N < 1 || N > 100)
            {
                throw new Exception("The number of lines n will be in the range [1 ... 100].");
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write($"|");
                string[] input = Console.ReadLine().Split(" - ");

                var company = input[0];
                var sum = int.Parse(input[1]);
                var product = input[2];

                OfficeStuff officeStuff = new OfficeStuff(company, sum, product);
                officestuffs.Add(officeStuff);
            }
            Console.WriteLine("--------------");
            LINQ(officestuffs);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }

    }

    static void LINQ(List<OfficeStuff> officestuffs)
    {
        var result = from o in officestuffs
                     group o by o.Company into g 
                     orderby g.Key
                     select new
                     {
                         Company = g.Key,
                         Product = string.Join(", ", g.Select(s => $"{s.Product}-{s.Sum}"))
                     };

        foreach (var r in result)
        {
            Console.WriteLine($"{r.Company}: {r.Product}");
        }

    }
}

/*
7
SoftServe - 600 - paper
Vivacom - 600 - pen
XS - 20 - chair
Vivacom - 200 - chair
SoftServe - 40 - chair
XS - 40 - chair
SoftServe - 1 - printer
 
 
 */