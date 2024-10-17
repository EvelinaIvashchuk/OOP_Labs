using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person() : this("No name", 1)
    {
    }

    public Person(int age) : this("No name", age)
    {
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

public class Family
{
    private List<Person> members = new List<Person>();

    public void adding_member(Person member)
    {
        members.Add(member);
    }
    public Person get_oldest_member()
    {
        return members.OrderByDescending(member => member.Age).FirstOrDefault();
    }
}

class Program
{
    static void Main()
    {
        Family family = new Family();

        family.adding_member(new Person("Pesho", 20));
        family.adding_member(new Person("Gosho", 18));
        family.adding_member(new Person("Stamat", 43));

        Person oldest = family.get_oldest_member();
        if (oldest != null)
        {
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
        else
        {
            Console.WriteLine("No members in the family.");
        }
    }
}
