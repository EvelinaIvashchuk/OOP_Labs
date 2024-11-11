class Program
{
    static void Main()
    {
        string filepath = "C:\\Users\\eva\\source\\repos\\Lab15\\01\\text.txt";

        StreamReader reader = new StreamReader(filepath);
        
            string line;
            var lettercount = 0;
            var punctuationcount = 0;
            var rows = 0;
            while ((line = reader.ReadLine()) != null)
            {

                foreach(char ch in line)
                {
                    if (char.IsLetter(ch))
                    {
                        lettercount++;
                    }
                    if (char.IsPunctuation(ch))
                    {
                        punctuationcount++;
                    }
                }

                rows++;

                Console.WriteLine($"Line {rows}: {line} ({lettercount})({punctuationcount})");

                lettercount = 0;
                punctuationcount = 0;
            }
        

    }

}