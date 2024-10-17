using System;

class Box<T>
{
    private T Value;

    public Box(T value)
    {
        this.Value = value;
    }

    public override string ToString()
    {
        return $"{Value.GetType()}: {Value}";
    }
}


class Program
{

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Box<string>> list = new List<Box<string>>();

        for (int i = 0; i < N; i++)
        {
            string s = Console.ReadLine();
            Box<string> box = new Box<string>(s);
            list.Add(box);
        }

        foreach (Box<string> box in list)
        {
            Console.WriteLine(box);
        }

    }

}