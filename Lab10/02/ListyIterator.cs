using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int current;

        public ListyIterator(List<T> collectionData)
        {
            list = new List<T>(collectionData);
            current = 0;
        }

        public bool Move()
        {
            if (current < list.Count - 1)
            {
                current++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            return current < list.Count - 1;
        }

        public void Print()
        {
            if (list.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }
            Console.WriteLine(list[current]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return PrintAll().GetEnumerator();
        }

        public IEnumerable<T> PrintAll()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}

