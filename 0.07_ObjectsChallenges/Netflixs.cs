using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Netflixs
    {
        //Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        //Methods -Silver Challenges
        public void GetSuggestion()
        {
            if(this.Rating > 3)
            {
                Console.WriteLine("This is a pretty good show.");
            }
            else
            {
                Console.WriteLine("Don't waste your time.");
            }
        }
            
    }
}
