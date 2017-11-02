using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collection_Psuedo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass exampleArrayClass = new ArrayClass();
            exampleArrayClass.CheckTheCapacity();

            List exampleListClass = new List();
            exampleListClass.CheckTheCapacity();
        }
    }
}
