using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03_ADC_C_
{
    public delegate string BooksFunctionDelegate(Books books);
    internal class BookFunctions
    {
        public static string GetTitle(Books B)
        {
            return $"Title: {B.Title}";
        }

        public static string GetAuthor(Books B)
        {
            return $"Author: {string.Join(", ", B.Authors)}";
        }

        public static string GetPrice(Books B)
        {
            return $"Price: ${B.Price}";
        }
    }
}
