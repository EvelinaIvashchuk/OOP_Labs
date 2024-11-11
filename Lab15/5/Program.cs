class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        string directoryPath = "C:\\Users\\eva\\source\\repos\\Lab15\\05";
        string fileoutput = "C:\\Users\\eva\\source\\repos\\Lab15\\05\\report.txt";

        if (Directory.Exists(directoryPath))
        {
            string[] files = Directory.GetFiles(directoryPath, command, SearchOption.AllDirectories);

            using (StreamWriter writer = new StreamWriter(fileoutput))
            {
                var groupedFiles = files.GroupBy(Path.GetExtension);
                foreach (var group in groupedFiles)
                {
                    writer.WriteLine($"{group.Key}:");
                    foreach (var file in group.OrderByDescending(f => new FileInfo(f).Length))
                    {
                        string fileName = Path.GetFileName(file);
                        long fileSizeInKb = new FileInfo(file).Length / 1024;
                        writer.WriteLine($"-- {fileName} - {fileSizeInKb} КБ");
                    }
                    writer.WriteLine(); 
                }
            }
                

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("File written completely!");
            Console.ResetColor();

        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Catalogy does not to exist.");
            Console.ResetColor();
        }
    }

   
}