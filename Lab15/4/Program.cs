class Program
{
    static void Main()
    {
        var input = "C:\\Users\\eva\\source\\repos\\Lab15\\04\\image.jpg";
        var output = "C:\\Users\\eva\\source\\repos\\Lab15\\04\\image1.jpg";

        var reader = new FileStream(input, FileMode.Open);
        var writer = new FileStream(output, FileMode.OpenOrCreate);
        byte[] buffer = new byte[4096];
        while (true)
        {
            int readBytes = reader.Read(buffer, 0, buffer.Length);
            if (readBytes == 0)
            {
                break;
            }

            writer.Write(buffer, 0, readBytes);
        }

        Console.Write("Your file is here: ");

        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(output);
        Console.ResetColor();
    }

}