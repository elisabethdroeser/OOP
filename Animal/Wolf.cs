using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Wolf : Animal
    {
        public string Color { get; set; }
        public Wolf(string Name, int Age, int Weight, string Color) : base(Name, Age, Weight)
        {
            this.Color = Color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Ouiiiiii");
        }
    }
}
