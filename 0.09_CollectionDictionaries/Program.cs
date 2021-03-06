﻿using System;
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
            Dictionary<string, string> awardWinners = new Dictionary<string, string>();

            awardWinners.Add("2006", "Happy Feet");
            awardWinners.Add("2007", "Ratatouille");
            awardWinners.Add("2008", "Wall-E");
            awardWinners.Add("2009", "UP");
            awardWinners.Add("2010", "Toy Story 3");

            foreach (var movie in awardWinners)
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

            //Gold
            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter a year");
                string inputYear = Console.ReadLine();

                if (awardWinners.ContainsKey(inputYear) && awardNominees.ContainsKey(inputYear))
                {
                    Console.WriteLine("To show winner, enter 'winner'. \n" +
                        "To show Nominees, enter 'nominees'. \n" +
                        "To end the application, enter 'stop.");
                    string operation = Console.ReadLine().ToLower();
                    switch (operation)
                    {
                        case "winner":
                            Console.WriteLine($"The winner of the {inputYear} was {awardWinners[inputYear]}. \n\n");
                            break;
                        case "nominees":
                            string nominees = String.Join(",", awardNominees[inputYear]);
                            Console.WriteLine($"The nominees of the {inputYear} were; {nominees}. \n\n");
                            break;
                        case "stop":
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Sorry, thats not a valid input.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a year between 2006 and 2010. \n\n");
                }
            }

            Console.ReadLine();

        }
    }
}
