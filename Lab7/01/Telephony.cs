using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELEPHONYPROGRAM
{
    class Telephony : Calling, Browsing
    {
       
        public Telephony()
        {

        }

        public void Calling(string[] input)
        {       
             foreach (string s in input) 
             {
                if (!s.Any(char.IsDigit))
                {
                    throw new Exception("Invalid number!");
                }
                Console.WriteLine($"Calling... {s}");
                Thread.Sleep(1000);
            }
        }

        public void Browsing(string[] input)
        {
            foreach (string s in input)
            {

                if (s.Any(char.IsDigit))
                {
                    throw new Exception("Invalid URL!");
                }
                Console.WriteLine($"Browsing... {s}");
                Thread.Sleep(1000);
            }

        }

    }
}
