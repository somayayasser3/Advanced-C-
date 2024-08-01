using System;
using System.Collections;
using System.Collections.Generic;

namespace C_Advanced_Assign2
{
    class Program
    {
        public static ArrayList ReverseArrayList(ArrayList arrayList)
        {
            int Size = arrayList.Count - 1;
            for(int i = 0; i <= Size/2; i++)
            {
                object Temp = arrayList[i];
                arrayList[i] = arrayList[Size-i];
                arrayList[Size-i] = Temp;
            }
            return arrayList;
        }

        public static List<int> EvenNumbersInList(List<int> list)
        {
            List<int> EvenList = new List<int>();
            foreach(int item in list)
            {
                if (item % 2 == 0)
                    EvenList.Add(item);
            }
            return EvenList;
        }
        static void Main(string[] args)
        {
            #region Part02
            #region Q1 - Reverse ArrayList
            //ArrayList arrayList = new ArrayList(5) { 7, 0, 9, 8, 2 };
            //ArrayList Res = new ArrayList();
            //Res = ReverseArrayList(arrayList);
            //foreach (int item in Res)
            //    Console.WriteLine(item);
            #endregion

            #region Q2 - Even Number From List
            //List<int> l = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> Res = EvenNumbersInList(l);
            //foreach (int item in Res)
            //    Console.WriteLine(item);
            #endregion

            #region Q3 - FixedSizeList

            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(7);
            //try
            //{ 
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(5);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(8);
            //fixedSizeList.Add(0);
            //fixedSizeList.Add(-1);
            //fixedSizeList.Add(12);
            //fixedSizeList.Add(10);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //for (int i = 0; i < fixedSizeList.LastIndex; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine($"Element #{i + 1} = {fixedSizeList.Get(i)}");
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //try
            //{
            //    int item = fixedSizeList.Get(12);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #endregion

            Console.ReadKey();
        }
    }
}
