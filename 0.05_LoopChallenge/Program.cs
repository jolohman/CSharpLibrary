﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_LoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //    for (int i = 0; i < 100; i = i + 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.Beep();
            //    Console.WriteLine("Blast Off!");

            //    for (int i = 100; i > 0; i-- )
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.Beep();
            //    Console.WriteLine("Blast Off!");
            //    Console.ReadLine();

            for (int i = 1; i < 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
