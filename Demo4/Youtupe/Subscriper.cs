using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Youtupe
{
    internal class Subscriper
    {
        public string Name { get; set; }

        public void Notify(Channel channel,Videos videos)
        {
            Console.WriteLine($"Channel {channel} Added A New Video {videos} Stay Toned {Name}");
        }

        override public string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
