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
        List<Box<string>> list = new List<Box<string>>();

        for (int i = 0; i < N; i++)
        {
            string s = Console.ReadLine();
            Box<string> box = new Box<string>(s);
            list.Add(box);
        }

        string toCompare = Console.ReadLine();

        var result = CountOfGreaterThan(list, toCompare);

        Console.WriteLine(result);
    }

    static int CountOfGreaterThan(List<Box<string>> list, string toCompare)
    {
        int count = 0;
        foreach (var box in list)
        {
            if (box.GetValue.Length > toCompare.Length) 
            {
                count++;
            }
        }
        return count;
    }
}