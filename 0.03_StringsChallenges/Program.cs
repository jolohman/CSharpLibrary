using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFName = "Fred";
            string myLName = "Opals";
            int myInt = 100;
            string FormatFName = String.Format("First Name = |{0,10}|", myFName);
            string FormatLName = String.Format("Last Name = |{0,10}|", myLName);
            string FormatPrice = String.Format("Price = |{0,10:C}|", myInt);
            Console.WriteLine(FormatFName);
            Console.WriteLine(FormatLName);
            Console.WriteLine(FormatPrice);
            Console.WriteLine();

            FormatFName = String.Format("First Name = |{0,-10}|", myFName);
            FormatLName = String.Format("Last Name = |{0,-10}|", myLName);
            FormatPrice = String.Format("Price = |{0,-10:C}|", myInt);
            Console.WriteLine(FormatFName);
            Console.WriteLine(FormatLName);
            Console.WriteLine(FormatPrice);
            Console.WriteLine();
            // The example displays the following output on a system whose current
            // culture is en-US:
            //          First Name = |      Fred|
            //          Last Name = |     Opals|
            //          Price = |   $100.00|
            //
            //          First Name = |Fred      |
            //          Last Name = |Opals     |
            //          Price = |$100.00   |

            FormatFName = String.Format("First Name = |{0,-5}|", myFName);
            FormatLName = String.Format("Last Name = |{0,-5}|", myLName);
            FormatPrice = String.Format("Price = |{0,-10:C}|", myInt);
            Console.WriteLine(FormatFName);
            Console.WriteLine(FormatLName);
            Console.WriteLine(FormatPrice);


            Console.ReadLine();
        }
    }
}
