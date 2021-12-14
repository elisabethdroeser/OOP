using System;

namespace OOP
{
    internal class Pelican : Bird
    {
        public string Mouth { get; set; }
        public Pelican(string Name, int Age, int Weight, int Height, string Mouth) : base(Name, Age, Weight, Height)
        {
            this.Mouth = Mouth;
        }
        public override void DoSound()
        {
            Console.WriteLine("Pipelipip");
        }
        public override string Stats()
        {
            return base.Stats() + $"Mouth: {Mouth}.";
            //return base.Stats() + $"Height: {Height}, Mouth: {Mouth}.";
        }
    }
}
