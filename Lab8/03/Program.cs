using _03;
using System.Buffers;

class Program
{
    static void Main()
    {
        List<Cat> cats = new List<Cat>();
        List<Tiger> tigers = new List<Tiger>();
        List<Owl> owls = new List<Owl>();
        List<Hen> hens = new List<Hen>();   
        List<Mouse> mouths = new List<Mouse>();
        List<Dog> dogs = new List<Dog>();

        Food food = null;

        string command = null;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] input = command.Split();
            string type = input[0];

            if (input.Length == 5)
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string LivingRegion = input[3];
                string Breed = input[4];

                if (type == "Cat")
                {
                    Cat cat = new Cat(name, weight, LivingRegion, Breed);
                    cats.Add(cat);
                }
                else if (type == "Tiger")
                {
                    Tiger tiger = new Tiger(name, weight, LivingRegion, Breed);
                    tigers.Add(tiger);
                }
            }

            if (input.Length == 4)
            {
                if (type == "Owl" || type == "Hen")
                {
                    string name = input[1];
                    double weight = double.Parse(input[2]);
                    double wingSize = double.Parse(input[5]);

                    if (type == "Owl")
                    {
                        Owl owl = new Owl(name, weight, wingSize);
                        owls.Add(owl);
                    }
                    else if(type == "Hen")
                    {
                        Hen hen = new Hen(name, weight, wingSize);
                        hens.Add(hen);
                    }
                }

                if (type == "Mouse" || type == "Dog")
                {
                    string name = input[1];
                    double weight = double.Parse(input[2]);
                    string LivingRegion = input[3];

                    if (type == "Mouse")
                    {
                        Mouse mouse = new Mouse(name, weight, LivingRegion);
                        mouths.Add(mouse);
                    }
                    else if (type == "Dog")
                    {
                        Dog dog = new Dog(name, weight, LivingRegion);
                        dogs.Add(dog);
                    }
                }
            }

            if (input.Length == 2)
            {
                int Quantity = int.Parse(input[1]);

                if(type == "Vegetable")
                {
                    food = new Vegetable(Quantity);
                }
                else if (type == "Fruit")
                {
                    food = new Fruit(Quantity);
                }
                else if(type == "Meat")
                {
                    food = new Meat(Quantity);
                }
                else if(type == "Seeds")
                {
                    food = new Seeds(Quantity);
                }
            }
        }

        foreach(var item in cats)
        {
            item.MakeSound();
            item.Eat(food);
            Console.WriteLine(item);
        }
        foreach(var item in tigers)
        {
            item.MakeSound();
            item.Eat(food);
            Console.WriteLine(item);
        }
        foreach (var item in owls)
        {
            item.MakeSound();
            item.Eat(food);
            Console.WriteLine(item);
        }
        foreach(var item in hens)
        {
            item.MakeSound();
            item.Eat(food);
            Console.WriteLine(item);
        }
        foreach(var item in mouths)
        {
            item.MakeSound();
            item.Eat(food);
            Console.WriteLine(item);
        }
        foreach( var item in dogs)
        {
            item.MakeSound();
            item.Eat(food);
            Console.WriteLine(item);
        }
    }
}

/*
Cat Pesho 1,1 Home Persian
Vegetable 4

Tiger Typcho 167,7 Asia Bengal
Vegetable 1
Dog Doncho 500 Street 
Vegetable 150
End

 */