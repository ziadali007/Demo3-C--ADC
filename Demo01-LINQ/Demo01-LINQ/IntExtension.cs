using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_LINQ
{
    internal static class IntExtension
    {
        public static int Revese(this int number)
        {
            int result = 0;
            while (number > 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }
            return result;
        }

        public static long Revese(this long number)
        {
            long result = 0;
            while (number > 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }
            return result;
        }

    }
}
