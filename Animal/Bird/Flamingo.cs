using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Flamingo : Bird
    {
        public string Feather { get; set; }
        public Flamingo(string Name, int Age, int Weight, int Height, int NumberOfLegs, string Feather) : base(Name, Age, Weight, Height)
        {
            this.Feather = Feather;
        }
        public override void DoSound()
        {
            Console.WriteLine("Pink panter");
        }
        public override string Stats()
        {
            return base.Stats() + $"Number Of Legs: {NumberOfLegs} + Feather: {Feather}.";
        }
    }
}
