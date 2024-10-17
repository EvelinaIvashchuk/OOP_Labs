//2
using System;

class Person
{
    private string name;
    private int age;

    public Person() : this("No name", 1) { }

    public Person(int age) : this("No name", age) { }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

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
}

class Program
{
    static void Main()
    {
        Person person_default = new Person();
        Person person_age = new Person(30);
        Person person_customisation = new Person("Evelina", 25);

        Console.WriteLine($"{person_default.Name} {person_default.Age}");
        Console.WriteLine($"{person_age.Name} {person_age.Age}");
        Console.WriteLine($"{person_customisation.Name} {person_customisation.Age}");
    }
}
