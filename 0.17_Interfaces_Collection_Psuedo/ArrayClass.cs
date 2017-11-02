using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collection_Psuedo
{
    class ArrayClass : IEum, IList, ICollect
    {
        public void IterateOvertheCollection()
        {
            Console.WriteLine("Iterating ove the array....");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Remove stuff to the array...");
        }

        public void AddStuff()
        {
            Console.WriteLine("Added stuff to the array...");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("The account in array is 5..."); 
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("You can't check capacity of an array...");
        }
    }
}
