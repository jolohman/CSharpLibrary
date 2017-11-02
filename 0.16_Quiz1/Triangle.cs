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
        public Triangle(int tbase, int height)
        {
            this.TBase = tbase;
            this.THeight = height;
        }

        //Properties
        public int TBase { get; set; }
        public int THeight { get; set; }

        //Method
        public override double Area()
        {
            return 0.5 * TBase * THeight;
        }
    }
}
