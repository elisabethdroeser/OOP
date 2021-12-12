using System;

namespace OOP
{
    internal class Pelican : Bird
    {
        public Pelican(string Name, int Age, int Weight, int Height, int NumberOfLegs) : base(Name, Age, Weight, Weight)
        {

        }
        public override void DoSound()
        {
            Console.WriteLine("Pipelipip");
        }
    }
}
