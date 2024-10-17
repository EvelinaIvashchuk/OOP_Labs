using _01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatcher
{
    public delegate void NameChangeEventHandler(NameChangeEventArgs args);
    class Dispatcher
    {
        private string name;
        public event NameChangeEventHandler NameChange;
        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(args);
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnNameChange(new NameChangeEventArgs(name));
            }
        }

    }
}
