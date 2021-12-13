using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string Name, int Age, int Weight, string Color) : base(Name, Age, Weight, Color)
        {
            
        }
        public void Talk()
        {
            Console.WriteLine("Come closer, I cannot see you enough!");
        }
    }
}
