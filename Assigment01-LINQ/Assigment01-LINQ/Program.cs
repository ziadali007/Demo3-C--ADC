
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using static Assigment01_LINQ.ListGenerators;
namespace Assigment01_LINQ
{
    #region Ordering Operators
    //class CaseInsensitiveComparer : IComparer<string>
    //{
    //    public int Compare(string x, string y)
    //    {
    //        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    //    }
    //} 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            //var OutOfStock = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var unit in OutOfStock)
            //{
            //    Console.WriteLine(unit);
            //}

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result=Arr.Where((S,I)=>S.Length < I);

            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //} 
            #endregion

            #region Element Operators
            //var result=ProductList.FirstOrDefault(p=>p.UnitsInStock == 0);

            //Console.WriteLine(result);

            //var result = ProductList.FirstOrDefault(p => p.UnitPrice>1000);

            //Console.WriteLine(result);

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr.Where(p=>p>5).FirstOrDefault();

            //Console.WriteLine(result); 
            #endregion

            #region Aggregate Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(p => p % 2 != 0);

            //Console.WriteLine(result);

            //var result = from c in CustomerList
            //             select new
            //             {
            //                 c.CustomerID,
            //                 OrderCount = c.Orders.Count()
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = from P in ProductList
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 NoOfProducts=P.ProductName.Count(),

            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr.Sum();

            //Console.WriteLine(result);


            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result=words.Sum(p => p.Length);

            //Console.WriteLine(result);


            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Min(p => p.Length);

            //Console.WriteLine(result);


            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Max(p => p.Length);

            //Console.WriteLine(result);


            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Average(p => p.Length);

            //Console.WriteLine(result);


            //var result=ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine(result);

            //var result = from P in ProductList
            //             group P by P.Category into categoryGroup
            //             select new
            //             {
            //                 Category = categoryGroup.Key,
            //                 CheapestPrice = categoryGroup.Min(p => p.UnitPrice)
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = from P in ProductList
            //             group P by P.Category into categoryGroup
            //             let CheapestPrice = categoryGroup.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = categoryGroup.Key,
            //                 CheapestPrice
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = from P in ProductList
            //             group P by P.Category into categoryGroup
            //             select new
            //             {
            //                 Category = categoryGroup.Key,
            //                 CheapestPrice = categoryGroup.Max(p => p.UnitPrice)
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = from P in ProductList
            //             group P by P.Category into categoryGroup
            //             select new
            //             {
            //                 Category = categoryGroup.Key,
            //                 CheapestPrice = categoryGroup.Average(p => p.UnitPrice)
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Ordering Operators
            //var result=ProductList.OrderBy(ProductList => ProductList.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(W=>W,new CaseInsensitiveComparer());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result=ProductList.OrderByDescending(P=>P.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(W => W.Length).ThenBy(W=>W);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(W => W.Length)
            //                                      .ThenBy(W => W,new CaseInsensitiveComparer());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(W => W.Length)
            //                                     .OrderByDescending(W => W, new CaseInsensitiveComparer());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Transformation Operators

            //var result=ProductList.Select(P=>P.ProductName).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(W =>
            //new
            //{
            //    Upper=W.ToUpper(),
            //    Lower=W.ToLower(),
            //});

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}


            //var result = ProductList.Select(P => new {P.ProductName,P.Category,Price = P.UnitPrice });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((P, I) => P == I).ToArray();

            //foreach (bool i in result)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}



            //var result = from C in CustomerList
            //             from O in C.Orders
            //             where O.Total < 500
            //             select new
            //             {
            //                 O.OrderID,
            //                 O.Total,
            //             };

            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}



            //var result = from C in CustomerList
            //             from O in C.Orders
            //             where O.OrderDate >= new DateTime(1998, 1, 1)
            //             select new
            //             {
            //                 O.OrderID,
            //                 O.Total,
            //                 O.OrderDate
            //             };

            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}



            #endregion

            #region Set Operators
            //var result=ProductList.Select(P=>P.Category).Distinct();

            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);

            //}



            //var result=(from P in ProductList
            //                       select P.ProductName
            //                       .FirstOrDefault()
            //                       into Product
            //                       from C in CustomerList
            //                       select C.CustomerName
            //                       .FirstOrDefault()).Distinct();

            //foreach (var item in result)
            //{

            //    Console.Write(item);

            //}



            //var customerLetters = CustomerList
            //                                    .Select(c => c.CustomerName)
            //                                    .FirstOrDefault();

            //var productLetters = ProductList
            //    .Select(p => p.ProductName)
            //    .FirstOrDefault();

            //var result = productLetters
            //    .Except(customerLetters)
            //    .Distinct()
            //    .OrderBy(c => c);

            //foreach (var item in result)
            //{

            //    Console.Write(item);

            //} 
            #endregion

            #region Partitioning Operators
            //var result = CustomerList
            //             .Where(C => C.City == "Washington")  
            //             .SelectMany(C => C.Orders)           
            //             .OrderBy(O => O.OrderDate)           
            //             .Take(3);


            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}




            //var result = CustomerList
            //             .Where(C => C.City == "Washington")
            //             .SelectMany(C => C.Orders)
            //             .OrderBy(O => O.OrderDate)
            //             .Skip(2);


            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((N, I) => N > I);

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}




            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where(N=>N%3==0);

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((N, I) => N > I);

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Quantifiers
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Any(word => word.Contains("ei"));


            //Console.WriteLine(result);




            //var result=ProductList.GroupBy(P=>P.Category)
            //                                                      .Where(P=>P.Any(p=>p.UnitsInStock==0))
            //                                                      .Select(P=> new
            //                                                      {
            //                                                          Category = P.Key,

            //                                                      });



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Category);
            //}




            //var result = ProductList.GroupBy(P => P.Category)
            //                                                      .Where(P => P.All(p => p.UnitsInStock > 0))
            //                                                      .Select(P => new
            //                                                      {
            //                                                          Category = P.Key,

            //                                                      });



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Category);
            //} 
            #endregion

            #region Grouping Operators
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(N => N % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"number with a reminder of {group.Key} when divided by 5:");
            //    foreach (var num in group)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}



            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(W => W[0]).ToDictionary(group => group.Key, group => group.ToList()); ;

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Letter '{group.Key}':");
            //    foreach (var word in group.Value.Take(5)) 
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("..."); 
            //} 
            #endregion










        }
    }
}
