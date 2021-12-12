using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Animal
    {
        //Add constructor to class with required fields
        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        private string Name { get; set; }
        private int Age { get; set; }
        private int Weight { get; set; }

        public void doSound()
        {
            Console.WriteLine("Animalsound!");
        }                                                                                   
    }
}
