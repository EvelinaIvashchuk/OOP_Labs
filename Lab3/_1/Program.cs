//1 
using System;

namespace PersonExample
{
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

        public Person()
        {
            name = "Evelina";
            age = 1;
        }

        public Person(int age)
        {
            name = "Stas";
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Person pesho = new Person("Pesho", 20);
            Person gosho = new Person("Gosho", 18);
            Person stamat = new Person("Stamat", 43);
            Console.WriteLine($"{pesho.Name}, {pesho.Age} years old");
            Console.WriteLine($"{gosho.Name}, {gosho.Age} years old");
            Console.WriteLine($"{stamat.Name}, {stamat.Age} years old");

            Person default_person = new Person();
            Console.WriteLine($"{default_person.Name}, {default_person.Age} years old");
            Person person_age = new Person(30);
            Console.WriteLine($"{person_age.Name}, {person_age.Age} years old");
        }
    }
}
