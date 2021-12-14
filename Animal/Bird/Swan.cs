using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Swan : Bird
    {
        public bool OnLand { get; set; }
        public Swan(string Name, int Age, int Weight, int Height, bool OnLand) : base(Name, Age, Weight, Height)
        {
            this.OnLand = OnLand;
        }
        public override void DoSound()
        {
            Console.WriteLine("Looking beutifuuuul");
        }
        ublic override string Stats()
        {
            return base.Stats() + $"OnLand: {OnLand}.";
        }
    }
}
