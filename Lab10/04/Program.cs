using _04;
using System.Text;

public class Program
{
    public static void Main()
    {
        DateTime data = DateTime.Now;
        Console.WriteLine(data);
        line();

        try
        {
            var peopleByName = new SortedSet<Person>(new PersonNameComparator());
            var peopleByAge = new SortedSet<Person>(new PersonAgeComparator());

            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] strings = Console.ReadLine().Split();
                var name = strings[0];
                var age = int.Parse(strings[1]);

                peopleByName.Add(new Person(name, age));
                peopleByAge.Add(new Person(name, age));
            }
            Console.WriteLine("---------");

            foreach (var person in peopleByName)
            {
                Console.WriteLine(person);
            }
            foreach (var person in peopleByAge)
            {
                Console.WriteLine(person);
            }
            line();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            line();
        }
        

    }

    static void line()
    {
        Console.WriteLine("--------------------------------------------------------------------------");
    }

}