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

        int[] value = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int value1 = value[0];
        int value2 = value[1];
        Swap(list, value1, value2);

        foreach (Box<string> box in list)
        {
            Console.WriteLine(box);
        }

    }

    static void Swap<T>(List<Box<T>> list, int value1, int value2)
    {
        Box<T> temp = list[value1];
        list[value1] = list[value2];
        list[value2] = temp;
    }



}