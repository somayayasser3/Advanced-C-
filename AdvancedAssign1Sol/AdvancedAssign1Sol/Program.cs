using System;

namespace AdvancedAssign1Sol
{
    class Program
    {
        public static void BubbleSort(int []array)
        {
            bool Flag ;
            for(int i = 0; i < array.Length; i++)
            {
                Flag = false;
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int Temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = Temp;
                        Flag = true;
                    }
                }
                if (!Flag) break;
            }
        }

        public static void PrintArr(int []array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            #region Q1- Bubble Sort
            //// We can Optimize Bubble Sort by Check on if Array is Already Sorted in The Firt Time in First For Loop 
            //// This Means That The Second Loop will Be Done Only One Time Then Break From All Loops  [N]
            //// so The Time Complexity is O(N) for second Loop Iteration [N] , First Loop Done One Time [1]
            //int[] Numbers = { 12, 14, 0, 3, 6, 8, 7, 9, -1, 14, 13 };
            //Console.WriteLine("Before Sorting: ");
            //PrintArr(Numbers);
            //BubbleSort(Numbers);
            //Console.WriteLine("After Sorting: ");
            //PrintArr(Numbers);
            #endregion

            #region Q2- Generic Range 
            var R1 = new Range<int>(5, 12);
            Console.WriteLine(R1.InRange(3));  
            Console.WriteLine($"Length of range: {R1.Length()}"); 

            var R2 = new Range<double>(5.3, 24.3);
            Console.WriteLine(R2.InRange(12.5));  
            Console.WriteLine($"Length of range: {R2.Length()}"); 
            #endregion
            Console.ReadKey();
        }
    }
}
