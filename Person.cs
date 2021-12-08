using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public uint Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Heigth { get; set; }
        public uint Weight { get; set; }   
  
        //Add constructor to class
        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName; 
        }
    }
}
