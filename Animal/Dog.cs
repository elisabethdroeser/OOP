using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dog : Animal
    {
        public int Height { get; set; }

        public Dog(string Name, int Age, int Weight, int Height) : base(Name, Age, Weight)
        {
            this.Height = Height;
        }

        public override void DoSound()
        {
            Console.WriteLine("Voff");
        }

        public override string Stats()
        {
            return base.Stats() + $"Height: {Height}.";
        }

        public void DoTrick()
        {
            Console.WriteLine("Dog Rolls Over");
        }
    }
}
