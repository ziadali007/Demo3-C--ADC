﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Fifa
{
    internal struct Location
    {
        public int X { get; set; }

        public int Y { get; set; }


        public int Z { get; set; }

        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }
    }
}
