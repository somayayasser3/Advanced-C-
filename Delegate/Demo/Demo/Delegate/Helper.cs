using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Delegate
{
    // After Using Predicate
   //  public delegate bool ConditionalDelegate<T>(T x);
    internal static class Helper
    {
        public static List<T> GetElementBasedOnPassedFunction<T>(List<T> Elements, Predicate <T>conditionalDelegate)
        {
            List<T> Result = new List<T>();
            if (Elements != null && conditionalDelegate != null)
            {
                for (int i = 0; i < Elements.Count; i++)
                {
                    // if (Numbers[i] % 2 != 0)
                    if (conditionalDelegate.Invoke(Elements[i]))
                        Result.Add(Elements[i]);
                }
            }
            return Result;
        }
        //public static List<int> GetNumberBasedOnPassedFunction(List<int> Numbers, ConditionalDelegate conditionalDelegate  )
        //{
        //    List<int> Result = new List<int>();
        //    if(Numbers != null && conditionalDelegate != null)
        //    {
        //        for(int i = 0; i < Numbers.Count ; i++)
        //        {
        //           // if (Numbers[i] % 2 != 0)
        //           if(conditionalDelegate.Invoke(Numbers[i]))
        //                Result.Add(Numbers[i]);
        //        } 
        //    }
        //    return Result;
        //}

        //public static List<int> GetEvenNumbers(List<int> Numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (Numbers != null)
        //    {
        //        for (int i = 0; i < Numbers.Count; i++)
        //        {
        //            if (Numbers[i] % 2 == 0)
        //                Result.Add(Numbers[i]);
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> DivisibleBySeven(List<int> Numbers)
        //{
        //    List<int> LiBySeven = new List<int>();
        //    foreach(int item in Numbers)
        //    {
        //        if (item % 7 == 0)
        //            LiBySeven.Add(item);
        //    }
        //    return LiBySeven;
        //}
    }
}
