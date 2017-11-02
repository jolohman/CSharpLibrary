using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle  newTriangle = new Triangle(3, 6);
            Console.WriteLine($"Trianlge's area = {newTriangle.Area()}");

            Triangle newTriangle1 = new Triangle(6, 12);
            Console.WriteLine($"Trianlge's area = {newTriangle1.Area()}");

            Triangle newTriangle2 = new Triangle(2, 8);
            Console.WriteLine($"Trianlge's area = {newTriangle2.Area()}");

            Triangle newTriangle3 = new Triangle(9, 12);
            Console.WriteLine($"Trianlge's area = {newTriangle3.Area()}");

            Triangle newTriangle4 = new Triangle(5, 7);
            Console.WriteLine($"Trianlge's area = {newTriangle4.Area()}");

            //Quiz Part 2
            //Create a List of Triangle objects using LINQ


            //My Attempt at LINQ(is all in the comments)
            Triangle[] Area = { newTriangle, newTriangle1, newTriangle2, newTriangle3, newTriangle4 };

            IEnumerable<Triangle> query = from a in Area
                                          where a.Area > 1
                                          orderby Area ascending
                                          select a;

            foreach (Triangle area in query)
            {
                Console.WriteLine(Area);
            }


            Console.ReadLine();
        }
    }
}
