using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            MobilePhone mobileJosh = new MobilePhone("Samsung", "S8");
            Console.WriteLine("I have a " + mobileJosh.Make + " " + mobileJosh.Model);
            //or a different version of string interpolation
            Console.WriteLine($"I own a {mobileJosh.Make} {mobileJosh.Model}");

            //Silver
            MobilePhone mobileAlexandra = new MobilePhone("Alexandra","Samsung", "S8");
            MobilePhone mobileAndrew = new MobilePhone("Andrew","iPhone", "5s");
            MobilePhone mobileJay = new MobilePhone("Jay","Google", "Pixel2 ");
            MobilePhone mobilePaul = new MobilePhone("Paul","Windows", "Lumia");

            //Use of a List to help move to Console.WriteLine()
            List<MobilePhone> phoneList = new List<MobilePhone>() { mobileAlexandra, mobileAndrew, mobileJay, mobilePaul, mobileJosh };

            foreach (var phone in phoneList)
            {
                Console.WriteLine($"{phone.Name} owns a {phone.Make} {phone.Model}.");
            }



            Console.ReadLine();
        }
    }
}
