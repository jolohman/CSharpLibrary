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

            Dictionary<string, string[]> awardNominees = new Dictionary<string, string[]>()
            {
                { "2006", new string[] {"Happy Feet", "Cars", "Monster House"} },
                { "2007", new string[] { "Ratatouille", "Persepolis", "Surf's U" } },
                { "2008", new string[] {"Wall-E", "Bolt", "Kung Fu Panda"} },
                { "2009", new string[] {"Up","Mr. Fantastic Fox", "Coraline"} },
                { "2010", new string[] {"Toy Story 3", "How to Train your Dragon", "The Illusionist"} }

            };

            foreach (var nominee in awardNominees)
            {
                Console.WriteLine($"Nominees for {nominee.Key}: {nominee.Value[0]}, {nominee.Value[1]}, {nominee.Value[2]}");
            }


            Console.ReadLine();

        }
    }
}
