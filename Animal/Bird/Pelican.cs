using System;

namespace OOP
{
    internal class Pelican : Bird
    {
        public string Mouth { get; set; }
        public Pelican(string Name, int Age, int Weight, int Height, string Mouth) : base(Name, Age, Weight, Weight)
        {
            this.Mouth = Mouth;
        }
        public override void DoSound()
        {
            Console.WriteLine("Pipelipip");
        }
    }
}
