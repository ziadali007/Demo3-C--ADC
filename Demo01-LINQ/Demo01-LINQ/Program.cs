namespace Demo01_LINQ
{

    #region Implicitly-DataType Var & Dynamic 
    //public static dynamic Print(dynamic data)
    //{
    //    //Console.WriteLine(data);
    //    return data;
    //} 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly-DataType Var & Dynamic 
            //var Data01 = "Ahmed";

            //dynamic Data02 = null;
            ////Console.WriteLine(Data02.GetType().Name);
            //Data02 = 123;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 123.5;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name); 
            #endregion

            #region Anonymous Type
            //var E01=new {Id =1, Name = "Ahmed" ,Salary=12000.0m};

            ////var E02 = new { Id = 1, Name = "Ahmed", Salary = 12000.0m };

            ////Console.WriteLine(E01.Id);

            ////Console.WriteLine(E01.GetType().Name);
            ////Console.WriteLine(E02.GetType().Name);

            ////Console.WriteLine(E01);

            //var E02=E01 with { Name = "Ali" };

            //Console.WriteLine(E02); 
            #endregion

            #region Extension Methods
            //int Number = 12345;

            //var ReversedNumber = Number.Revese();

            //Console.WriteLine(ReversedNumber);

            //long Number = 12345;

            //var ReversedNumber = Number.Revese();

            //Console.WriteLine(ReversedNumber); 
            #endregion

            #region What Is LINQ
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 , 9 , 10};

            ////var result = Numbers.Where(n => n % 2 == 0);

            ////var result = Enumerable.Any(Numbers,n => n % 2 == 0);

            //var result = Enumerable.Range(1,100);




            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region LINQ Syntax
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result= Enumerable.Where(Numbers, n => n % 2 == 0);

            //var result=Numbers.Where(n => n % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            //var result=from N in Numbers
            //                         where N % 2 == 0
            //                         select N;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region LINQ Execution Ways
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(n => n % 2 == 0);

            //Numbers.AddRange(new List<int> { 11, 12, 13, 14, 15 });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(n => n % 2 == 0).ToList();

            //Numbers.AddRange(new List<int> { 11, 12, 13, 14, 15 });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //} 
            #endregion
        }

    }
}