using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 28;

            string myName = "Samuel";

            bool nonTruth = false;

            float birthYear = 1989;

            double currentYear = 2017;

            decimal exactAge = 28.45M;

            //Declaration with Intializer

            int yearsOld;

            string countryBorn;

            bool theTruth;

            float birthDay;

            double month;

            decimal upcomingAge;

            yearsOld = 28;

            birthDay = 3;

            month = 6;

            countryBorn = "I was born in USA and I'm currently " + yearsOld + " years old born on " + birthYear + "/" + month + "/" + birthDay;
            Console.WriteLine(countryBorn);

            Console.ReadLine();

        }
    }
}
