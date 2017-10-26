using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            string[] favFoods = new string[3];
            favFoods[0] = "Ice Creams";
            favFoods[1] = "Cookies";
            favFoods[2] = "Milkshakes";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(favFoods[i]);
            }

            //Silver

            int[] numbers1 = new int[5] { 3, 4, 4, 5, 5 };
            int[] numbers2 = new int[5] { 7, 2, 43, 2, 12 };

            int[] numbers3 = new int[5];

            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = numbers1[i] + numbers2[i];
                
            }
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }

            //Gold

            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }


            //My Atempt
            string[] favoriteFoods = { "Hot Pot", "MaLa XiangGuo", "Chocolate Chip Cookies" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(favoriteFoods[i]);
            }

            Console.ReadLine();
        }
    }
}
