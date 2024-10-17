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
        List<Box<int>> list = new List<Box<int>>();

        for (int i = 0; i < N; i++)
        {
            int s = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>(s);
            list.Add(box);
        }

        foreach (Box<int> box in list)
        {
            Console.WriteLine(box);
        }
    }

}