using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dispatcher;

namespace _01
{
    class Handler
    {
        public void OnDispatcherNameChange(NameChangeEventArgs e)
        {
            Console.WriteLine($"Dispatcher's name changed to {e.Name}.");
        }
    }
}
