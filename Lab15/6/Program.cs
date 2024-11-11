using System.IO.Compression;

class Program
{
    static void Main()
    {
        try
        {
            string path1 = @"C:\Users\eva\source\repos\Lab15\create";
            string zipfile = @"C:\Users\eva\source\repos\Lab15\file.zip";
            string path2 = @"C:\Users\eva\source\repos\Lab15\extract";

            ZipFile.CreateFromDirectory(path1, zipfile);
            ZipFile.ExtractToDirectory(zipfile, path2);
        }
        catch (Exception ex)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }
}