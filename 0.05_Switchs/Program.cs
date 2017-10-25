using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Switchs
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Jay";
            int age = 15;

            switch(friend)
            {
                case "Jay":
                    Console.WriteLine("Hey Jay.");
                    Console.ReadLine();
                    break;
                case "Paul":
                    Console.WriteLine("Paul is pretty cool");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("I don't know you");
                    Console.ReadLine();
                    break;
            }

            switch(age)
            {
                case 21:
                    Console.WriteLine("You can drink alcohol.");
                    break;
            }
        }
    }
}
