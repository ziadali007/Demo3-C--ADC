using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Fifa
{
    internal class Player
    {
        public string Name { get; set; }

        public string TeamName { get; set; }

        public void Run(Ball ball)
        {
            Console.WriteLine($"Player {Name} Is Running At {ball}");
        }

        public override string ToString()
        {
            return $"Name: {Name} Team Name: {TeamName}";
        }


    }
}
