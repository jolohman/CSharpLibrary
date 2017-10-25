using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ConditionalsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How happy would you say your are today? (1-5): ");
            string feelingNumber = Console.ReadLine();
            if (feelingNumber == "5")
            {
                Console.WriteLine("Hello Sunshine!");
                Console.ReadLine();
            }


            else if (feelingNumber == "4")
            {
                Console.WriteLine("Almost on Cloud Nine, huh?");
                Console.ReadLine();
            }

            else if (feelingNumber == "3")
            {
                Console.WriteLine("There are better days.");
                Console.ReadLine();
            }

            else if (feelingNumber == "2")
            {
                Console.WriteLine("Naps make things better.");
                Console.ReadLine();
            }

            else if (feelingNumber == "1")
            {
                Console.WriteLine("Cheer up buddy! Because tomorrow is only a day away!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Wow that bad.... You should seek a professional...");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
