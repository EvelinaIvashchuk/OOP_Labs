class Program
{
    static void Main()
    {
        string filepath = "C:\\Users\\eva\\source\\repos\\Lab15\\01\\text.txt";

        StreamReader reader = new StreamReader(filepath);

        string line;
        var rows = 0;
        while ((line = reader.ReadLine()) != null)
        {
            line = line.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");

            if (rows % 2 == 1)
            {
                Console.WriteLine(line);
            }


            rows++;
        }


    }

}