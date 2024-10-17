using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using _02;

class Program
{
    static void Main()
    {
        List<string> strings = new List<string>();
        ListyIterator<string> listyiterator = null;

        DateTime data = DateTime.Now;
        Console.WriteLine(data);
        line();

        try
        {
            bool created = false;
            string command = null;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                string function = input[0];

                if (input.Length > 1)
                {
                    if (function == "Create")
                    {
                        if (!created)
                        {
                            for (int i = 1; i < input.Length; i++)
                            {
                                strings.Add(input[i]);
                            }
                            listyiterator = new ListyIterator<string>(strings);
                            created = true;
                        }
                        else
                        {
                            throw new Exception("The Create command can only be used once!");
                        }
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
                    else if (function == "PrintAll")
                    {
                        foreach (string listy in listyiterator)
                        {
                            Console.Write(listy + " ");
                        }
                        Console.WriteLine();
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