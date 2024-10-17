using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using ListOperation;

class Program
{
    static void Main()
    {
        try
        {
            var strings = new List<string>();
            ListyIterator<string> listyiterator = null;

            DateTime data = DateTime.Now;
            Console.WriteLine(data);
            line();

            string command = null;
       
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                string function = input[0];

                if (input.Length > 1)
                {
                    if (function == "Create")
                    {
                        for (int i = 1; i < input.Length; i++)
                        {
                            strings.Add(input[i]);
                        }
                        listyiterator = new ListyIterator<string>(strings);
                    }

                }

                if (input.Length == 1)
                {
                    if (function == "Print")
                    {
                        listyiterator.Print();
                    }
                    else if (function == "Move")
                    {
                        Console.WriteLine(listyiterator.Move());
                    }
                    else if (function == "HasNext")
                    {
                        Console.WriteLine(listyiterator.HasNext());
                    }
                    else
                    {
                        Console.WriteLine("Something wrong!");
                    }
                }
            }
            line();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            line();
        }

    }


    static void line()
    {
        Console.WriteLine("--------------------------------------------------------------------------");
    }
}