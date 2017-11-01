using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array of instructors [] = array
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            //Loop thorugh the array using the query
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            //Example 2
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1, Name="Johnboy", HireDate = new DateTime(2015,3,5)},
                new Employee {ID=2, Name="Madcap", HireDate = new DateTime(1860,7,27)},
                new Employee {ID=3, Name="Susan", HireDate = new DateTime(2016,9,17)},
                new Employee {ID=4, Name="Huckleberry", HireDate = new DateTime(2005,8,2)},
                new Employee {ID=5, Name="Keisha", HireDate = new DateTime(2016,3,21)},
                new Employee {ID=7, Name="Oz", HireDate = new DateTime(1989,6,3)}
            };

            IEnumerable<Employee> queryTwo = from e in employees
                                           where e.HireDate.Year == 2016
                                           orderby e.Name ascending
                                           select e;

            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();
        }
    }
}
