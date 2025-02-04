using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_C__ADC
{
    //public delegate bool CheckNumbersDelegate(int X);

    public delegate bool CheckNumbersDelegate<T>(T X);

    internal class ConditionsFunctions
    {
        public static bool CheckEvenNumbers(int X) {  return X%2== 0; }

        public static bool CheckOddNumbers(int X) { return X % 2 != 0; }

        public static bool CheckDivisableByFourNumbers(int X) { return X % 4 == 0; }


        public static bool CheckEvenNameLength(string X) { return X.Length % 2 == 0; }

        public static bool CheckOddNameLength(string X) { return X.Length % 2 != 0; }

        public static bool CheckDivisableByFourNameLength(string X) { return X.Length % 4 == 0; }

    }
}
