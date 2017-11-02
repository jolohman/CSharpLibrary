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

            IEnumerable<Triangle> query1 = from a in Area
                                          where a.TArea > 1
                                          orderby a.TArea ascending
                                          select a;

            foreach (Triangle area in query1)
            {
                Console.WriteLine(Area);
            }


            //Database of Data(Collection)
            IEnumerable<Triangle> triangles = new List<Triangle>
            {
                newTriangle,
                newTriangle1,
                newTriangle2,
                newTriangle3,
                newTriangle4
            };


            //Setup query using LINQ
            IEnumerable<Triangle> query = from t in triangles
                                          where t.TArea > 14
                                          orderby t.TArea ascending
                                          select t;

            foreach (Triangle triangle in query)
            {
                Console.WriteLine(triangle.TArea);
            }


            Console.ReadLine();
        }
    }
}
