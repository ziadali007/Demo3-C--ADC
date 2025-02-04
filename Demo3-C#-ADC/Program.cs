namespace Demo3_C__ADC
{
    internal class Program
    {
        #region Delegate Ex01
        //public delegate int StringFuncDelegate(string Word); 
        #endregion

        #region Delegate EX02
        //public static void PrintArray<T>(T[] Arr)
        //{
        //    Console.WriteLine();
        //    for (int i = 0; i < Arr.Length; i++)
        //    {

        //        Console.Write($"{Arr[i]} ");
        //    }
        //    Console.WriteLine();

        //} 
        #endregion

        #region Delegate EX03

        //public static List<T> FindElements<T>(List<T> numbers, CheckNumbersDelegate<T> reference)
        //{
        //    List<T> result = new List<T>();

        //    if (numbers?.Count > 0)
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //        {

        //            if (reference(numbers[i]))
        //                result.Add(numbers[i]);
        //        }
        //    }

        //    return result;
        //}



        //public static List<int> FindElements(List<int> numbers,CheckNumbersDelegate reference)
        //{
        //    List<int> result = new List<int>();

        //    if (numbers?.Count > 0)
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //        {

        //            if (reference(numbers[i]))
        //                result.Add(numbers[i]);
        //        }
        //    }

        //    return result;
        //}


        ////public static List<int> FindOddNumbers(List<int> numbers)
        ////{
        ////    List<int> result = new List<int>();

        ////    if (numbers?.Count > 0)
        ////    {
        ////        for (int i = 0; i < numbers.Count; i++)
        ////        {

        ////            if (numbers[i] % 2 != 0)
        ////                result.Add(numbers[i]);
        ////        }
        ////    }

        ////    return result;
        ////}

        ////public static List<int> FindEvenNumbers(List<int> numbers)
        ////{
        ////    List<int> result = new List<int>();

        ////    if (numbers?.Count > 0)
        ////    {
        ////        for (int i = 0; i < numbers.Count; i++)
        ////        {

        ////            if (numbers[i] % 2 == 0)
        ////                result.Add(numbers[i]);
        ////        }
        ////    }

        ////    return result;
        ////}

        ////public static List<int> FindDivisableByFourNumbers(List<int> numbers)
        ////{
        ////    List<int> result = new List<int>();

        ////    if (numbers?.Count > 0)
        ////    {
        ////        for (int i = 0; i < numbers.Count; i++)
        ////        {

        ////            if (numbers[i] % 4 == 0)
        ////                result.Add(numbers[i]);
        ////        }
        ////    }

        ////    return result;
        ////} 
        //public static void PrintList<T>(List<T> list)
        //{
        //    Console.WriteLine();

        //    foreach(T item in list) Console.Write($"{item} ");

        //    Console.WriteLine();

        //}
        #endregion

        #region Built-In Delegates
        //public static int Fun01()
        //{
        //    return 1;
        //}

        //public static string Fun02(int x) { return $"{x}"; }

        //public static void Print(string x)
        //{
        //    Console.WriteLine(x);
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Delegate Ex01
            //StringFuncDelegate X;

            //X = StringFunctions.GetCountOfUpperCaseChars;

            //X += StringFunctions.GetCountOfLowerCaseChars;

            //int Result = X("Hello World");

            //Console.WriteLine(Result); 
            #endregion

            #region Delegate EX02
            //int[] Arr = { 3, 4, 6, 7, 3, 9, 4, 5, 66, 88, 22, 99, 12 };

            //PrintArray(Arr);

            //SortingAlgorithms.BubbleSort(Arr);

            //SortingAlgorithms.BubbleSortAscending(Arr);

            //SortingAlgorithms.BubbleSortDescending(Arr);

            //SortingFuncDelegate X;

            //X = SortingConditions.CompareLess;

            ////SortingAlgorithms.BubbleSort(Arr, X);

            //SortingAlgorithms.BubbleSort(Arr, SortingConditions.CompareGtr);

            //PrintArray(Arr); 


            //string[] strings = { "Ahmed", "Ali", "Mona", "Yassin", "Nada" };

            //PrintArray(strings);

            ////SortingAlgorithms.BubbleSort(strings, SortingConditions.CompareGtr);
            //SortingAlgorithms.BubbleSort(strings, SortingConditions.CompareLess);


            //PrintArray(strings);
            #endregion

            #region Delegate EX03
            //List <int> numbers = new List<int>();

            //numbers=Enumerable.Range(1,100).ToList();

            ////List<int> OddNumbers=FindOddNumbers(numbers);
            ////List<int> EvenNumbers = FindEvenNumbers(numbers);
            ////List<int> DivisableByFourNumbers = FindDivisableByFourNumbers(numbers);

            ////PrintList(OddNumbers);
            ////PrintList(EvenNumbers);
            ////PrintList(DivisableByFourNumbers);

            //CheckNumbersDelegate X = ConditionsFunctions.CheckEvenNumbers;

            ////List<int> FindElement = FindElements(numbers,X);

            ////List<int> FindElement = FindElements(numbers, ConditionsFunctions.CheckOddNumbers);

            //List<int> FindElement = FindElements(numbers, ConditionsFunctions.CheckDivisableByFourNumbers);

            //PrintList(FindElement); 


            //List<string> strings =new List<string> { "Ahmed", "Ali", "Mona", "Yassin", "Nada" };

            //List<string> EvenNames = FindElements(strings, ConditionsFunctions.CheckEvenNameLength);

            //PrintList(EvenNames);

            //List<string> OddNames = FindElements(strings, ConditionsFunctions.CheckOddNameLength);

            //PrintList(OddNames);

            //List<string> DivisableByFourNames = FindElements(strings, ConditionsFunctions.CheckDivisableByFourNameLength);

            //PrintList(DivisableByFourNames);



            #endregion

            #region Built-In Delegates
            //Predicate<int> predicate = ConditionsFunctions.CheckEvenNumbers;

            //bool r=predicate(1);

            //Console.WriteLine(r);

            //Func<int> fun=Fun01;
            //Func<int,string> fun2=Fun02;

            //Console.WriteLine(fun());
            //Console.WriteLine(fun2(5));


            //Action<string> action = Print; 
            #endregion














        }
    }
}
