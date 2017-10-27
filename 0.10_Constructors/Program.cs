using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Old Method with out a Constructor (VERY WET)

            //Student studentJay = new Student();
            //studentJay.FirstName = "Jay";
            //studentJay.LastName = "Jackson";
            //studentJay.Grade = 1;
            //studentJay.Age = 5;

            //With a Constructor

            Student studentJosh = new Student("Josh", "Lohman", 15, 9);

            Student studentPaul = new Student("Pual", "O'Conner", 12);

            Student studentJay = new Student("Jay");


        }
    }
}
