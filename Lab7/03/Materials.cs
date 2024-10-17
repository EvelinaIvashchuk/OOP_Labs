class Materials
{
    public static void DISPLAY()
    {
        string data = DateTime.Now.ToString("dd-MM-yyyy");
        string time = DateTime.Now.ToString("HH:mm:ss");
        Console.Write(data);
        Console.Write("         -SPECIAL MANAGEMENT OF MILITARY MISSIONS-         ");
        Console.WriteLine(time);
        LINE();
    }

    public static void LINE()
    {
        Console.WriteLine("-----------------------------------------------------------------------------");
    }

    public static void SmallLine()
    {
        Console.WriteLine("------------------------");
    }

}