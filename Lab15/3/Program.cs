using System.Linq;

class Program
{
    static void Main()
    {
        string filepath1 = "C:\\Users\\eva\\source\\repos\\Lab15\\01\\text.txt";
        string filepath2 = "C:\\Users\\eva\\source\\repos\\Lab15\\03\\words.txt";

        if (File.Exists(filepath1) && File.Exists(filepath2))
        {
            var writetext1 = File.ReadAllText(filepath1);
            var writetext2 = File.ReadAllText(filepath2);

            string result = "";
            var textWords = CleanAndSplit(writetext1);
            var words = CleanAndSplit(writetext2);

            foreach (var word in words)
            {
                int count = textWords.Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase)); 
                result += $"{word} - {count}\n";
            }

            string result2 = "";
            var words2 = words.
                Select(word => new 
                { 
                    Word = word, 
                    Count = textWords.Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase))
                })
                .OrderByDescending(x => x.Count); 

            foreach (var word in words2)
            {
                result2 += $"{word.Word} - {word.Count}\n";
            }

            string filepath3 = "C:\\Users\\eva\\source\\repos\\Lab15\\03\\actualResult.txt";
            string filepath4 = "C:\\Users\\eva\\source\\repos\\Lab15\\03\\expectedResult.txt";

            File.WriteAllText(filepath3, result);
            File.WriteAllText(filepath4, result2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Completed!");
            Console.ResetColor();
        }      
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("False!");
            Console.ResetColor();
        }

    }

    static string[] CleanAndSplit(string text)
    {
        var cleanedText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
        return cleanedText.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    }
}