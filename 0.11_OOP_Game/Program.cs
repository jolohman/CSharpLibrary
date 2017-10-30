using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character myName = new Character();
            Player newHero = new Player();
            Enemy jenn = new Enemy();

            Console.WriteLine("Hello, wanderer..\n" +
                "What be thy name?");
            newHero.Name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Nice to meet you, {newHero.Name}.");

            Console.WriteLine("What is you specialization friend? \n" +
                "1:Horse Mange\n" +
                "2:Troll Cat \n" +
                "3:Knight Templatetor\n" +
                "4:Demogorg \n" +
                "5:Sire Cena");

            Player.Specialization = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
