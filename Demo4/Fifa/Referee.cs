using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Fifa
{
    internal class Referee
    {
        public string Name { get; set; }

        public void Look(Ball ball)
        {
            Console.WriteLine($"Referee {Name} Is Looking At {ball}");
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
