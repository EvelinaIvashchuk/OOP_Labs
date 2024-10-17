using System.Xml.Linq;

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

    public T GetValue
    {
        get { return Value; }
        set { Value = value; }
    }

}


class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<Box<float>> list = new List<Box<float>>();

        for (int i = 0; i < N; i++)
        {
            float s = float.Parse(Console.ReadLine());
            Box<float> box = new Box<float>(s);
            list.Add(box);
        }

        float toCompare = float.Parse(Console.ReadLine());

        var result = CountOfGreaterThan(list, toCompare);

        Console.WriteLine(result);
    }

    static int CountOfGreaterThan(List<Box<float>> list, float toCompare)
    {
        int count = 0;
        foreach (var box in list)
        {
            if (box.GetValue > toCompare)
            {
                count++;
            }
        }
        return count;
    }
}

/*
3
7,13
123,22
42,78
7,55
 
 */