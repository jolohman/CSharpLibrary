using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Quiz1
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(double tbase, double height)
        {
            this.TBase = tbase;
            this.THeight = height;
        }

        //Properties
        public double TBase { get; set; }
        public double THeight { get; set; }
        public double TArea { get; set; }

        //Method
        public override double Area()
        {
            this.TArea = this.TBase * this.THeight / 2.0;
            return this.TArea;
        }
    }
}
