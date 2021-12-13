using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Flamingo : Bird
    {
        public Flamingo(string Name, int Age, int Weight, int Height, int NumberOfLegs) : base(Name, Age, Weight, Weight)
        {

        }
        public override void DoSound()
        {
            Console.WriteLine("Pink panter");
        }
    }
}
