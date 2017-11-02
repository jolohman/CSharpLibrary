using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collection_Psuedo
{
    class List : IList, ICollect, IEum
    {
        public void AddStuff()
        {
            Console.WriteLine("Add stuff to list");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Check capacity of list");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Check the count of list");
        }

        public void IterateOvertheCollection()
        {
            Console.WriteLine("Iterating over list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Remove stuff from list");
        }
    }
}
