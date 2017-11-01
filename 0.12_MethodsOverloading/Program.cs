using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Player class with an Attack() method;
            //that accepts 3 different sets of parameters
            //
            //for Example:
            //Attack(100) -->                       "Attacked for 100!"
            //Attacking(100, "Weapon") -->          "Attaked with Weapon for 100!"
            //Attack(100, "Weapon", #ofTimes) -->   "Attacked with Weapon for #ofTimes, dealing totalDamage!"

            Player me = new Player();
            me.Attack(500, "Katana", 90);

            Console.ReadLine();
        }
    }
}
