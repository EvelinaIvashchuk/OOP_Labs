using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03
{
    public class JobHandler
    {
        public void OnJobCompleted(Job job)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Job {job.Name} done!");
            Console.ResetColor();
        }
    }
}
