using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GetterSetters
{
    class Employee
    {
        //public int ID { get; set; }
        //public string Name { get; set; }

        //Fields (Backing Field)
        private int _id;
        private string _name;
        private string _workQuote;

        //Properties(includes exceptions)
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                    throw new Exception("The employee ID is invalid");
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //if (value == string.Empty)
                //or
                if(String.IsNullOrWhiteSpace(value))
                    throw new Exception("The employee name is invalid");
                //Trim takes off all the spaces from the start and ending
                _name = value.Trim();
            }
        }

        //Methods
        public void SetWorkQuote(string quote)
        {
            this._workQuote = quote;
        }

        public string GetQuote()
        {
            return this._workQuote;
        }

    }
}
