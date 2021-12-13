using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Bird : Animal
    {
        public int NumberOfLegs { get; set; }
        public Bird(string Name, int Age, int Weight, int NumberOfLegs) : base(Name, Age, Weight)
        {
            this.NumberOfLegs = NumberOfLegs;
        }
        public override void DoSound()
        {
            Console.WriteLine("Piiiip");
        }
    }
}
