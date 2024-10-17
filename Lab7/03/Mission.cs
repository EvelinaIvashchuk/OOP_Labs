using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Mission
    {
        public string CodeName { get; set; }
        public string Status { get; set; }

        public Mission(string codeName, string status)
        {
            CodeName = codeName;
            Status = status;
        }

        public override string ToString()
        {
            return $"   Code name: {CodeName}, Status: {Status}";
        }
    }
}
