using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03_ADC_C_
{
    internal class LibraryEngine
    {

        public static void ProcessBooks(List<Books> bList, BooksFunctionDelegate reference)
        {
            foreach (Books book in bList)
            {

                Console.WriteLine(reference(book));
            }
        }

        public static void ProcessBooks<T>(List<T> bList, Func<T,T> reference)
        {
            foreach (var book in bList)
            {

                Console.WriteLine(reference(book));
            }
        }


    }
}
