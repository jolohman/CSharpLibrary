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


            Console.ReadLine();
        }
    }
}
