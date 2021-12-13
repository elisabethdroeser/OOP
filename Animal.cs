using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     internal abstract class Animal
    {
        //Add constructor to class with required fields
        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        //Add method 
        public abstract void DoSound();
                                                                                  
    }


}
