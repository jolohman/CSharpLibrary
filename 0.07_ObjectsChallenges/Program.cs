using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Instantiation
            Netflixs breakingBad = new Netflixs();
            Netflixs theITCrowd = new Netflixs();
            Netflixs theWalkingDead = new Netflixs();
            Netflixs pinkPanther = new Netflixs();

            //Set Object Values
            breakingBad.Name = "Breaking Bad";
            breakingBad.Genre = "Suspense";
            breakingBad.Rating = 5;

            theITCrowd.Name = "The IT Crowd";
            theITCrowd.Genre = "Comedy";
            theITCrowd.Rating = 4;

            theWalkingDead.Name = "The Walking Dead";
            theWalkingDead.Genre = "Horror/Suspense";
            theWalkingDead.Rating = 5;

            pinkPanther.Name = "Pink Panther";
            pinkPanther.Genre = "Comedy";
            pinkPanther.Rating = 3;

            //Calling the Methods(Invoking, Executing Functions/methods)
            //Silver Challenge
            //breakingBad.GetSuggestion();
            //theITCrowd.GetSuggestion();
            //theWalkingDead.GetSuggestion();
            //pinkPanther.GetSuggestion();


            //Gold Challenge
            List<Netflixs> favoriteShows = new List<Netflixs>();

            favoriteShows.Add(breakingBad);
            favoriteShows.Add(theITCrowd);
            favoriteShows.Add(theWalkingDead);
            favoriteShows.Add(pinkPanther);

            foreach (Netflixs show in favoriteShows)
            {
                Console.WriteLine(show.Name);
                Console.WriteLine(show.Genre);
                Console.WriteLine(show.Rating);
                show.GetSuggestion();
            }


            //My Attempt for the Challenges
            //Console.Write("Which Netflix show are you interested in Breaking Bad, The IT Crowd, The Walking Dead, or Pink Panther?");
            //string show = Console.ReadLine();
            //if (show == "Breaking Bad")
            //{
            //    Console.WriteLine(breakingBad.Name);
            //    Console.WriteLine(breakingBad.Genre);
            //    Console.WriteLine(breakingBad.Rating);
            //    Console.WriteLine("Once you start you can't stop!!!");
            //    Console.ReadLine();
            //    ;
            //}

            //else if (show == "The IT Crowd")
            //{
            //    Console.WriteLine(theITCrowd.Name);
            //    Console.WriteLine(theITCrowd.Genre);
            //    Console.WriteLine(theITCrowd.Rating);
            //    Console.WriteLine("You might pee your pants!!!");
            //    Console.ReadLine();
            //}

            //else if (show == "The Walking Dead")
            //{
            //    Console.WriteLine(theWalkingDead.Name);
            //    Console.WriteLine(theWalkingDead.Genre);
            //    Console.WriteLine(theWalkingDead.Rating);
            //    Console.WriteLine("Don't plan on sleeping because you will be doomsday prepping");
            //    Console.ReadLine();
            //}

            //else if (show == "Pink Panther")
            //{
            //    Console.WriteLine(pinkPanther.Name);
            //    Console.WriteLine(pinkPanther.Genre);
            //    Console.WriteLine(pinkPanther.Rating);
            //    Console.WriteLine("If you are searching this you have exhausted you options... sorrry");
            //    Console.ReadLine();
            //}

            //else
            //{
            //    Console.WriteLine("That show did not make our list... Maybe next year....");
            //    Console.ReadLine();
            //}

            Console.ReadLine();
        }
    }
}
