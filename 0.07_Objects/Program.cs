using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donuts PaulDonut = new Donuts();
            Donuts KennDonut = new Donuts();
            Donuts JoshDonut = new Donuts();
            Donuts JayDonut = new Donuts();

            KennDonut.Filling = "Cherry Jelly";
            KennDonut.Price = 0;
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;

            PaulDonut.Filling = "Cherry Jelly";
            PaulDonut.Price = 7.99M;
            PaulDonut.Type = "Jelly";
            PaulDonut.IsSpecial = true;

            JoshDonut.Filling = "Chocolate Creme";
            JoshDonut.Price = 5.00M;
            JoshDonut.Type = "Double Chocolate";
            JoshDonut.IsSpecial = true;

            JayDonut.Filling = "Creme";
            JayDonut.Price = 3.50M;
            JayDonut.Type = "AngelCreme";
            JayDonut.IsSpecial = false;

            Console.WriteLine(PaulDonut.IsSpecial);
            Console.ReadLine();

        }
    }
}
