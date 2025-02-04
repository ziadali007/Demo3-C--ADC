using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_C__ADC
{

    //public delegate bool SortingFuncDelegate(int X, int Y);

    public delegate bool SortingFuncDelegate<T>(T X, T Y);
    internal class SortingAlgorithms
    {



        public static void BubbleSort<T>(T[] Arr, SortingFuncDelegate<T> reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {

                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }


        //public static void BubbleSort(int[] Arr,SortingFuncDelegate reference)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (reference.Invoke(Arr[j],Arr[j+1]))
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}




        //public static void BubbleSortAscending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            for(int j = 0; j < Arr.Length-i-1; j++)
        //            {
        //                if(Arr[j] > Arr[j+1])
        //                    SWAP(ref Arr[j],ref Arr[j+1]);
        //            }
        //        }
        //    }
        //}


        //public static void BubbleSortDescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] < Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}


        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        public static void SWAP<T>(ref T A, ref T B)
        {
            T temp = A; A = B; B = temp;
        }
        //public static void SWAP(ref int A,ref int B)
        //{
        //    int temp=A; A=B; B=temp;
        //}
    }
}
