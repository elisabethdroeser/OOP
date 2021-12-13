using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Wolf : Animal
    {
        public Wolf(string Name, int Age, int Weight, int Height) : base(Name, Age, Weight)
        {

        }
        public override void DoSound()
        {
            Console.WriteLine("Ouiiiiii");
        }
    }
}
