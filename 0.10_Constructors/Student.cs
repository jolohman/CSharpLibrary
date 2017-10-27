using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Student
    {
        //Constructors (more effective)
        
        //Constructer 3 (Order made
        //No Objects to make the wet code work
        public Student()
        {

        }

        //Constructor 4
        public Student(string firstName)
        {
            this.FirstName = firstName;
        }

        ////Constructor 5
        //// Nothing to show a difference between this and the firstName
        //public Student(string lastName)
        //{
        //    this.LastName = lastName;
        //}

        //Constructor 6
        public Student(string lastName, int grade)
        {
            this.LastName = lastName;
            this.Grade = grade;
        }
        
        //Constructor 1
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        //Constructor 2
        public Student(int age, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Constructor 3
        //Stage 1(the first one we wrote) Overloaded Constructor
        public Student(string firstName, string lastName, int age, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
        }

        //Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }


    }
}
