using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class OfficeStuff
    {
        public string company;
        public int sum;
        public string product;

        public OfficeStuff(string company, int sum, string product)
        {
            Company = company;
            Sum = sum;
            Product = product;
        }

        public int Sum
        {
            get { return sum; }
            set
            {
                if (value < 1 || value > 1000)
                {
                    throw new Exception("Sum will be an integer in the range [1 ... 1000].");
                }
                else
                {
                    sum = value;
                }
            }
        }
        public string Company
        {
            get { return company; }
            set
            {
                if (value.Length < 1 || value.Length > 20)
                {
                    throw new Exception($"{company} consist of Latin characters only, length [1 ... 20].");
                }
                else
                {
                    company = value;
                }
            }
        }

        public string Product
        {
            get { return product; }
            set
            {
                if (value.Length < 1 || value.Length > 20)
                {
                    throw new Exception($"{product} consist of Latin characters only, length [1 ... 20].");
                }
                else
                {
                    product = value;
                }
            }
        }


    }
}
