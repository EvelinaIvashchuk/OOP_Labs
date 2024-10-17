using _02;

class Program
{
    static void Main()
    {
        try
        {
            var engine = new Engine();
            engine.Run();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
        
    }
}
