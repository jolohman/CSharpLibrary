using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenge
{
    class MobilePhone
    {
        //Constructors
        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        //Silver Constructor
        public MobilePhone(string name, string make, string model)
        {
            this.Name = name;
            this.Make = make;
            this.Model = model;
        }

        //Properties

        public string Name { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        //Methods
        //Simple method to print

        public void PrintPhone()
        {
            Console.WriteLine($"{this.Name} own a {this.Make} {this.Model}");
        }

    }
}
