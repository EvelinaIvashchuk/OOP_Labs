using _05;
using System.Text;

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
            Console.WriteLine(ex.Message);
        }
       
    }

}