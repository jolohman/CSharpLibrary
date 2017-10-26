using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_CollectionDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            Dictionary<int, string> openWith = new Dictionary<int, string>();

            openWith.Add(2000, "American Beauty");
            openWith.Add(2001, "Gladiator");
            openWith.Add(2002, "A Beautiful Mind");
            openWith.Add(2003, "Chicago");
            openWith.Add(2005, "The Lord of the Rings: The Return of the King");

            foreach (var movie in openWith)
            {
                Console.WriteLine($"{movie.Key} the winner was {movie.Value}");
            }

            //Silver


            Console.ReadLine();

        }
    }
}
