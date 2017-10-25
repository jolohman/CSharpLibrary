using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Steve";
            lastName = "Rogers";
            occupation = "Captain America";

            string fullName = firstName +" " + lastName;
            Console.WriteLine(fullName);
            //V0
            Console.WriteLine("Hello, my name is " + fullName + ". I am a " + occupation + ".");

            //String Interpolation
            //V1
            Console.WriteLine("Hello, my name is {0}. I am a {1}.", fullName, occupation);
            //V2
            Console.WriteLine($"Hello, my name is {fullName}. I am a {occupation}.");


            Console.ReadLine();

        }
    }
}
