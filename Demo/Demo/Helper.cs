using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    // Generic Class
    // In Case Generic Type <T> Is Declared On Class Or Struct Or Interface
    // Compiler Can Not Detect the type of T 
    internal class Helper<T> where T : /*class,*/ /* General Primary Constrain*/ IComparable<T> // Constructor Constrain , new()
    {
        // Primary Constrain
        // 1. Class
        // 2. Or Nullable Struct ==> Notnull
        // 3. or Class with its Name

        // Secondary Constrain
        // Constructor Constrain with Class 
        // T Must be Class Or Struct Implement Interface IComparable
        T Salary { get; set; } // Generic on Class

        public static T Sum(T X, T Y)
        {
            return X + Y; // Invalid
        }
        #region Non Generics
        //public static void SWAP(ref int x, ref int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}


        //public static void SWAP(ref double x, ref double y)
        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}

        //public static void SWAP(ref Point P1, ref Point P2)
        //{
        //    Point Temp = P1;
        //    P1 = P2;
        //    P2 = Temp;
        //}


        //public static void BUbbleSort(int [] array)
        //{
        //    if(array != null)
        //    {
        //        for(int i = 0; i < array.Length; i++)
        //        {
        //            for(int j = 0; j<array.Length-i-1; j++)
        //            {
        //                if(array[j] > array[j+1])
        //                {
        //                    Helper.SWAP<int>(ref array[j], ref array[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Generics
        // T ==> Generic Type
        // SWAP ==> Generic Method
        // In Case Type <T> Is Declared on Method Level, Not Class Or Struct Or Interface
        // Compiler can detect the type of T based on Passed Paremeters 
        // For Readability only , we can Add it in Calling
        public static void SWAP(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }


        public static int SearchArray(T[] array, T value)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    //if (value == array[i]) // Invalid ==> use Equal Function instead 
                    if(value.Equals(array[i]))
                        return i;
                }
            }
            return -1;
        }

        public static void BUbbleSort(T[] array)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        // if (array[j] > array[j + 1])
                        if(array[j].CompareTo(array[j+1]) == 1)
                        {
                           SWAP(ref array[j], ref array[j + 1]);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
