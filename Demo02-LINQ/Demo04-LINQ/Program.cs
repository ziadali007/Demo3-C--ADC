using System.Collections;
using System.Text.RegularExpressions;
using static Demo04_LINQ.ListGenerator;
namespace Demo04_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filteration Operator
            //var result=ProductList.Where(p=>p.UnitsInStock==0);

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;

            //var result = ProductList.Where(p => p.UnitsInStock > 0).Where(p => p.Category== "Meat/Poultry");

            //var result=ProductList.Where(p => p.UnitsInStock > 0 && p.Category== "Meat/Poultry");

            //var result = from p in ProductList
            //                              where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //select p;

            //var result=ProductList.Where(p => p.UnitsInStock > 0).Where((p,I) => I < 5);
            //foreach (var product in result)
            //{
            //    System.Console.WriteLine(product);
            //}

            //ArrayList arrayList = new ArrayList(){1,2,3, "Ahmed", "Ali", 1.5, 1.7f, 1.8m, ProductList[0], ProductList[1] };

            //var result = arrayList.OfType<Product>();

            //foreach (var product in result)
            //{
            //    System.Console.WriteLine(product);
            //} 
            #endregion

            #region Transforamation Operators
            //var result = ProductList.Select(p=>p.ProductName);

            //var result= from p in ProductList
            //                            select p.ProductName;


            //var result=ProductList.Where(p=>p.UnitsInStock>0 && p.Category == "Meat/Poultry")
            //                                      .Select(p =>new{ Name = p.ProductName, Category=p.Category});

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry")
            //                                      .Select(p => new { Name = p.ProductName,
            //                                                                Category = p.Category, 
            //                                                                OldPrice=p.UnitPrice, 
            //                                                                NewPrice=p.UnitPrice-p.UnitPrice*0.1m });


            //var result=from p in ProductList
            //           where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //           select new
            //           {
            //               Name = p.ProductName,
            //               Category = p.Category,
            //               OldPrice = p.UnitPrice,
            //               NewPrice = p.UnitPrice - p.UnitPrice * 0.1m
            //           };


            //var result=CustomerList.SelectMany(c => c.Orders);

            //var result= from c in CustomerList
            //                                                                   from o in c.Orders
            //                                                                   select new { c.CustomerID, o.OrderID, o.OrderDate };


            //var result=ProductList.Select((P,I)=> new {I,P.ProductName })
            //                                                                                   .Where(P=>P.I<5);
            //foreach (var product in result)
            //{
            //    System.Console.WriteLine(product);
            //} 
            #endregion

            #region Ordering Operators
            //var result = ProductList.OrderBy(p => p.UnitPrice);
            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //                                               .Select(p=>new
            //                                               {
            //                                                   p.ProductName,
            //                                                   p.UnitPrice,
            //                                                   p.UnitsInStock
            //                                               });

            //var result = ProductList.OrderByDescending(p => p.UnitPrice)
            //                                               .Select(p => new
            //                                               {
            //                                                   p.ProductName,
            //                                                   p.UnitPrice,
            //                                                   p.UnitsInStock
            //                                               });

            //var result = ProductList.OrderByDescending(p => p.UnitsInStock)
            //                                               .ThenBy(p => p.UnitPrice)
            //                                               .Select(p => new
            //                                               {
            //                                                   p.ProductName,
            //                                                   p.UnitPrice,
            //                                                   p.UnitsInStock
            //                                               });

            //var result = ProductList.OrderByDescending(p => p.UnitsInStock)
            //                                               .ThenByDescending(p => p.UnitPrice)
            //                                               .Select(p => new
            //                                               {
            //                                                   p.ProductName,
            //                                                   p.UnitPrice,
            //                                                   p.UnitsInStock
            //                                               });

            //var result = ProductList.Where(p=> p.Category == "Meat/Poultry")
            //                                              .OrderByDescending(p => p.UnitsInStock)
            //                                              .ThenByDescending(p => p.UnitPrice)
            //                                              .Select(p => new
            //                                              {
            //                                                  p.ProductName,
            //                                                  p.UnitPrice,
            //                                                  p.UnitsInStock
            //                                              });

            //var result= from p in ProductList
            //            where p.Category == "Meat/Poultry"
            //            orderby p.UnitsInStock descending, p.UnitPrice ascending
            //            select new
            //            {
            //                p.ProductName,
            //                p.UnitPrice,
            //                p.UnitsInStock
            //            };

            //foreach (var product in result)
            //{
            //    System.Console.WriteLine(product);
            //}

            //var result=ProductList.Reverse<Product>();

            //foreach (var product in result)
            //{
            //    System.Console.WriteLine(product);
            //} 
            #endregion

            #region Elements Operators
            //ProductList = new List<Product>();

            //var result = ProductList.First();

            //var result = ProductList.First(p=>p.UnitsInStock==0);

            //var result = ProductList.Last();

            //var result = ProductList.Last(p => p.UnitsInStock == 0);

            //var result = ProductList.FirstOrDefault();

            //var result = ProductList.FirstOrDefault(new Product() { ProductName="Default"});

            //var result = ProductList.FirstOrDefault(p=>p.UnitsInStock==1000,new Product() { ProductName = "Default" });

            //var result = ProductList.LastOrDefault();

            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Default" });

            //var result = ProductList.LastOrDefault(p => p.UnitsInStock == 1000, new Product() { ProductName = "Default" });

            //var result=ProductList.ElementAt(5);

            //var result = ProductList.ElementAtOrDefault(5);

            //var result = ProductList.Single();

            //var result = ProductList.Single(P=>P.UnitsInStock==0);

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0);

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0, new Product() { ProductName = "Default" });


            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000,new Product() { ProductName="Default"});

            //Console.WriteLine(result);

            //var result = ProductList.DefaultIfEmpty();

            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default" });

            //foreach (var product in result)
            //{
            //    System.Console.WriteLine(product);
            //} 
            #endregion

            #region Aggergate Operators
            //var result=ProductList.Count();

            //var result = ProductList.Count;

            //var result = ProductList.Count(p=>p.UnitsInStock==0);

            //var result = ProductList.Where(p=>p.UnitsInStock==0).Count();

            //System.Console.WriteLine(result);

            //var result = ProductList.Max();

            //var result = ProductList.Max(new ProductComparerUnitInStock());

            //var result = ProductList.Max(p=>p.UnitPrice);

            //var result = ProductList.MaxBy(p => p.UnitPrice);

            //Console.WriteLine(result);

            //List<string> Names =new List<string> { "Ahmed", "Ali", "Mohamed", "Hassan", "Omar" };

            //var result=Names.Aggregate((S01,S02)=> $"{S01}{S02}");

            //System.Console.WriteLine(result); 
            #endregion

            #region Casting Operators
            //List<Product> products=ProductList.Where(p => p.UnitsInStock == 0).ToList();

            //Product[] products = ProductList.Where(p => p.UnitsInStock == 0).ToArray();

            //Dictionary<long,Product> products = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);

            //HashSet<Product> products = ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();

            //foreach (var product in products)
            //{
            //    System.Console.WriteLine(product);
            //} 
            #endregion

            #region Generation Operators
            //var result=Enumerable.Range(1, 100);

            //var result= Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() { ProductID = 1, ProductName = "Product 1", Category = "Category 1", UnitPrice = 10, UnitsInStock = 100 });
            //result.Add(new Product() { ProductID = 2, ProductName = "Product 2", Category = "Category 2", UnitPrice = 20, UnitsInStock = 200 });
            //result.Add(new Product() { ProductID = 3, ProductName = "Product 3", Category = "Category 3", UnitPrice = 30, UnitsInStock = 300 });

            //var result = Enumerable.Repeat(ProductList[1],3);

            //foreach (var item in result)
            //{
            //    System.Console.WriteLine(item);
            //} 
            #endregion

            #region Set Operators
            //var Seq01=Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var result=Seq01.Union(Seq02);
            //var result = Seq01.Concat(Seq02);
            //var result = Seq01.Intersect(Seq02);
            //var result = Seq01.Except(Seq02);
            //result = result.Distinct();

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Quantifier Operators
            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var result=Seq01.Any();

            //var result = Seq01.Any(i => i % 2==0);

            //var result = Seq01.All(i => i % 2 == 0);

            //var result = Seq01.Contains(50);

            //var result=Seq01.SequenceEqual(Seq02);

            //Console.WriteLine(result); 
            #endregion

            #region Zip Operator
            //List<string> Words= new List<string> { "Ten", "Twenty", "Thirty", "Forty", "Fifty" };

            //List<int> Numbers = new List<int> { 10, 20, 30, 40, 50 , 60 , 70 , 80 };

            //var result = Words.Zip(Numbers, (W, N) => $"{W} {N}");

            //foreach (var item in result)
            //{
            //    System.Console.WriteLine(item);
            //} 
            #endregion

            #region Grouping Operator
            //var result=ProductList.GroupBy(p => p.Category);

            //var result=from p in ProductList
            //           group p by p.Category;

            //foreach (var group in result)
            //{
            //    System.Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //    {
            //        System.Console.WriteLine(product);
            //    }
            //}


            //var result = from p in ProductList
            //                                            where p.UnitsInStock > 0
            //                                            group p by p.Category
            //                                            into Category
            //                                            where Category.Count() > 5
            //                                            select new
            //                                            {
            //                                                CategoryName = Category.Key,
            //                                                CountOfCategory = Category.Count()
            //                                            };


            //var result = ProductList.Where(p => p.UnitsInStock > 0)
            //                                            .GroupBy(p => p.Category)
            //                                            .OrderByDescending(c => c.Count())
            //                                            .Where(Category => Category.Count() > 5)
            //                                            .Select(Category => new
            //                                            {
            //                                                CategoryName = Category.Key,
            //                                                CountOfCategory = Category.Count()
            //                                            });


            //foreach (var group in result)
            //{
            //    System.Console.WriteLine(group);
            //} 
            #endregion

            #region Partioning Operators
            //var result = ProductList.Where(p => p.UnitsInStock == 0).Take(3);

            //var result = ProductList.Where(p => p.UnitsInStock == 0).TakeLast(3);

            //var result = ProductList.Where(p => p.UnitsInStock == 0).Skip(3);

            //var result = ProductList.Where(p => p.UnitsInStock == 0).SkipLast(3);

            //int[] Numbers = {9,6,1,2,3,4,5};

            //var result=Numbers.TakeWhile(n=>n%3==0);

            //var result = Numbers.SkipWhile(n => n % 3 == 0);

            //foreach (var product in result)
            //{
            //    System.Console.WriteLine(product);
            //} 
            #endregion

            #region Let & Into
            //List<string> Names= new List<string> { "Ahmed", "Ali", "Mohamed", "Hassan", "Omar" ,"Hassanien","Ibrahim"};

            //var result=from Name in Names
            //                       select Regex.Replace(Name, "[aeiouAEIOU]", string.Empty)
            //                       into NovoName
            //                       where NovoName.Length > 3
            //                       select NovoName;

            //var result = from Name in Names
            //             let NovoName= Regex.Replace(Name, "[aeiouAEIOU]", string.Empty)
            //             where NovoName.Length > 3
            //             select NovoName;


            //foreach (var item in result)
            //{
            //    System.Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
