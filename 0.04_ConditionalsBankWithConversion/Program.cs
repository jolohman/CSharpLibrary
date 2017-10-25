using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ConditionalsBankWithConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money do you have if your bank account? $");
            string balance = Console.ReadLine();
            int myMoney = Convert.ToInt32(balance);
            if (myMoney >= 10000)
            {
                Console.WriteLine("Marry me!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wow that bad.... You should seek a professional...");
                Console.ReadLine();
            }
        }
    }
}
