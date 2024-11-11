using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    public class Filter
    {
        public string Type { get; set; }
        public int Parameter { get; set; }

        public Filter(string type, int parameter)
        {
            Type = type;
            Parameter = parameter;
        }
    }
}
