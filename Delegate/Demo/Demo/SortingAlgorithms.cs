using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    // public delegate TResult CompareFuncDelegate<in T , out TResult>(T A, T B);
    internal class SortingAlgorithms <T>
    {
        #region Non Generic Bubble Sort
        //public static void BubbleSort(int [] Arr, CompareFuncDelegate compareFuncDelegate)
        //{
        //    if(Arr != null)
        //    {
        //        for(int i = 0 ; i < Arr.Length; i++)
        //        {
        //            for(int j = 0; j < Arr.Length-i-1; j++)
        //            {
        //                // Call Function in Another Function [Functional Programming]
        //                if (/*CompareFunctions.CompareGreater(Arr[j], Arr[j+1])*/ compareFuncDelegate(Arr[j], Arr[j+1])) // we can use invoke or not [Synatx Sugar]
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortDesc(int[] Arr)
        //{
        //    if (Arr != null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] < Arr[j + 1])
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion
        private static void Swap(ref T v1, ref T v2)
        {
            T Temp = v1;
            v1 = v2;
            v2 = Temp;
        }
        

        #region Generic Bubble Sort
        public static void BubbleSort(T[] Arr, Func<T,T , bool> compareFuncDelegate)
        {
            if (Arr != null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        // Call Function in Another Function [Functional Programming]
                        if (/*CompareFunctions.CompareGreater(Arr[j], Arr[j+1])*/ compareFuncDelegate(Arr[j], Arr[j + 1])) // we can use invoke or not [Synatx Sugar]
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
