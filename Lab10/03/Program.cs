using _03;

class Program
{
    static void Main()
    {
        var people = new List<Person>();

        string command = null;
        while ((command = Console.ReadLine()) != "END") 
        {
            string[] input = command.Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            var town = input[2];    

            people.Add(new Person(name, age, town));
        }

        var target_number = int.Parse(Console.ReadLine());
        if (target_number < 0 || target_number >= people.Count)
        {
            Console.WriteLine("No matches");
            return;
        }

        var targetPerson = people[target_number];

        var equalityCount = CountEqual(targetPerson, people);
        if (equalityCount <= 1)
        {
            Console.WriteLine("No matches");
            return;
        }

        var differenceEqualCount = CountDifferent(targetPerson, people);
        Console.WriteLine($"{equalityCount} {differenceEqualCount} {people.Count}");
    }
    static int CountDifferent(Person targetPerson, List<Person> people)
    {
        var different = 0;

        for (int i = 1; i < people.Count; i++)
        {
            if (people[i - 1].CompareTo(people[i]) != 0)
            {
                different++;
            }
        }

        return different;
    }

    static int CountEqual(Person targetPerson, List<Person> people)
    {
        var equal = 1;

        for (int i = 1; i < people.Count; i++)
        {
            if (people[i - 1].CompareTo(people[i]) == 0)
            {
                equal++;
            }
        }

        return equal;
    }

}
