using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Horse : Animal, IPerson
    {
        public string Mane { get; set; }
        public Horse(string Name, int Age, int Weight, string Mane) : base(Name, Age, Weight)
        {
            this.Mane = Mane;
        }
        public override void DoSound()
        {
            Console.WriteLine("Gnääägg");
        }

        public override string Stats()
        {
            return base.Stats() + $"Mane: {Mane}.";
        }

        public void Talk()
        {
            Console.WriteLine("Jag är en kentaur!");
        }
    }
}
