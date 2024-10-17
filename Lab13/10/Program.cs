using _10;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        try
        {
            List<Person> persons = new List<Person>();

            string command = null;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                var firstname = input[0];
                var lastname = input[1];
                var group = input[2];


                Person person = new Person(firstname, lastname, group);
                persons.Add(person);
            }
            Console.WriteLine("--------------");
            LINQ(persons);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void LINQ(List<Person> persons)
    {
        var result = from p in persons
                     group p by p.Group into g
                     orderby g.Key
                     select new
                     {
                         Group = g.Key,
                         Persons = string.Join(", ", g.Select(s => $"{s.FirstName} {s.LastName}"))
                     };

        foreach (var group in result)
        {
            Console.WriteLine($"{group.Group} - {group.Persons}");
        }
    }


}