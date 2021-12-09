using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Animal
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private int Weight { get; set; }

        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight; 
        }
    }

}
