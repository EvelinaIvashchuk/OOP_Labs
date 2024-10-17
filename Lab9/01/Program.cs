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
        Box<int> box1 = new Box<int>(1234);
        Box<string> box2 = new Box<string>("life in a box");

        Console.WriteLine(box1);
        Console.WriteLine(box2);


    }

}