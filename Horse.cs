using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Horse : Animal
    {
        public Horse(string Name, int Age, int Weight, int Height) : base(Name, Age, Weight)
        {

        }
        public override void DoSound()
        {
            Console.WriteLine("Gnääägg");
        }
        public int Height { get; set; }
    }
}
