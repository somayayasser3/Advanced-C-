using Demo.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    // Step 0: Declare Delegate
    public delegate int StringFuncDelegate(string str);
    public delegate int[] SortingAlgorithmsDelegate(int[] Arr);
    // New Class [Delegate]
    // Can refere to one Function or More [Static Or Non Static]
    // New Class [Delegate]
    // Any Reference From This Delegate Can Refer To 
    // Function Or More [Pointer To Function]
    // This Function May be Static Function [Class Member Function]
    // This Function May be Non Static Function [Object Member Function]
    // But These Functions Must be with the Same Signature of The Delegate 
    // Regardless Function Name & Access Modifier

    #region Built_In Delegates
    // 1. Predicate
    // Can Refer to Function That Take One Parameter [Of Any Data Type] Only and Returns Bool
    
    // 2. Func 
    // Can Refer to Function That Take [ 0 ..... 16 ] Parameters [Of Any Data Type] and Must Be Return
    
    // 3. Action
    // Can Refer to Function That Take [0 ....... 16 ] Parameters [Of Any Data Tyep] and Must Be Void [No Return Type] 

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            #region Ex01
            //// Delegate is a C# Language Feature
            //// has 2 Usage
            //// 1. Pointer To Function
            //// 2. Event - Driven Programming
            //int X = 5;
            //// int Y = StringFunctions.GetCountOfUpperChars; // Invalid to store into int variable
            //// So we Need to define Delegate
            //// Step 01: Declare Reference from Delegate
            //StringFuncDelegate stringFuncDelegate;
            //// Step 02: Initialize Reference From Delegate[Pointer To Function]
            //stringFuncDelegate = new StringFuncDelegate(StringFunctions.GetCountOfUpperChars);
            //// Synatx Sugar
            //// StringFuncDelegate = StringFunctions.GetCountOfUpperChars;
            //// Step 03: Use Delegate Reference[Call Method]
            ////int Res = stringFuncDelegate.Invoke("Somaya Yasser");
            ////Console.WriteLine($"Upper = {Res}"); // 2

            //// stringFuncDelegate = StringFunctions.GetCountOfLowerChars;
            //// stringFuncDelegate => GetCountOfLowerCharsOnly
            //// We use += Operator
            //// stringFuncDelegate => GetCountOfUpperChars + GetCountOfLowerChars
            //stringFuncDelegate += StringFunctions.GetCountOfLowerChars;
            //int r = stringFuncDelegate.Invoke("Somaya Yasser");
            //// Will Invoke All The Functions the Delegeta have its Address 
            //// Then the Result will Be the Result Of the Last Function Had Been Called 
            //Console.WriteLine($"Lower = {r}");
            //stringFuncDelegate -= StringFunctions.GetCountOfLowerChars;
            //// will Hold Only Upper Now
            //// stringFuncDelegate => GetCountOfUpperChars
            //r = stringFuncDelegate.Invoke("Somaya Yasser");
            //// Will Invoke All The Functions the Delegeta have its Address 
            //// Then the Result will Be the Result Of the Last Function Had Been Called 
            //Console.WriteLine(r);
            #endregion

            #region Ex02
            //int[] Numbers = { 10, 2, 3, 4, 15, 1, 8, 20, 10, 0 };
            //SortingAlgorithms<int>.BubbleSort(Numbers, CompareFunctions.CompareGreater);
            //foreach (int item in Numbers)
            //    Console.WriteLine(item);
            //SortingAlgorithms<int>.BubbleSort(Numbers, CompareFunctions.CompareLess);
            //Console.WriteLine("================================================");
            //foreach (int item in Numbers)
            //    Console.WriteLine(item);
            #endregion

            #region Ex03
            //string[] Names = { "Ahmed", "Yousef", "Somaya", "Sara", "Nour", "Ali", "Omar" };
            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunctions.CompareStringLess);
            //foreach (string s in Names)
            //    Console.WriteLine(s);
            #endregion

            #region Ex04
            //List<int> Number = Enumerable.Range(1, 100).ToList();
            //List<int> OddNumbers = Helper.GetElementBasedOnPassedFunction(Number, ConditionFunction.CheckOdd);
            //Console.WriteLine("Odd Numbers: ");
            //for (int i = 0; i < OddNumbers.Count; i++)
            //{
            //    Console.WriteLine(OddNumbers[i]);
            //}
            //Console.WriteLine("Even Numbers: ");
            //List<int> EvenNumbers = Helper.GetElementBasedOnPassedFunction(Number, ConditionFunction.CheckEven);
            //foreach (int item in EvenNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Divisible By Seven Numbers: ");
            //List<int> BySeven = Helper.GetElementBasedOnPassedFunction(Number, ConditionFunction.CheckDivisibleBySeven);
            //foreach (int item in BySeven)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Divisible By Ten Numbers: ");
            //List<int> ByTen = Helper.GetElementBasedOnPassedFunction(Number, ConditionFunction.CheckDivisibleByTen);
            //foreach (int item in ByTen)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ex05
            //List<string> Names = new List<string>()
            //{
            //    "Ahmed", "Omar","Yousef","Sara","Ali","Somaya","Nour"
            //};

            //List<string> Res = Helper.GetElementBasedOnPassedFunction/*<string>*/(Names, ConditionFunction.CheckStringLength);
            //foreach (string item in Res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Ex06 [Predicat]
            //Predicate<int> predicate; // Ref => Fun Take Only One int Paramater and Return Bool
            //predicate = TestingFunctions.Test01;
            //bool Flag = predicate.Invoke(4); // == predicate(4)
            //Console.WriteLine(Flag);




            #endregion

            #region Ex07 [Func]
            //Func<int , string> func; // Fun ==> Take One Parameter [int] and Return [String]
            //func = TestingFunctions.Test02;
            //Console.WriteLine(func(7)); // Casting From Int To String

            #endregion

            #region Ex08 [Action]
            //// Non Generic ==> Takes No Parameters and Return No Parameters
            ////Action action; // Non Generic [0 Parameter - Void Return]
            ////action = TestingFunctions.Test03;
            ////action.Invoke();
            //Action<string> action ; // Generic [ 1 int Parameter - Void Return]
            //action = TestingFunctions.Test04;
            //action.Invoke("Somaya");


            #endregion

            #region Ex09 [Anonymous Functions]
            //// When We Use Function For Only One Time 
            //// We Don't Need To Implement it in Class
            //// We Can Use Functional Programming Using Anonymous Function
            //// Assign Delegate With The Built Of Function Not Only Its Name
            //// Then Add delegate before its implementation
            //// Anonymous Methos : C# 2.0 [2005]
            //Predicate<int> predicate = delegate(int x) { return x > 0; };
            //Console.WriteLine(predicate(4));

            //Func<int, string> func; // Fun ==> Take One Parameter [int] and Return [String]
            //func =  delegate(int X) { return X.ToString();};
            //Console.WriteLine(func(7)); // Casting From Int To String

            ////// Non Generic ==> Takes No Parameters and Return No Parameters
            //Action action; // Non Generic [0 Parameter - Void Return]
            //action = delegate{Console.WriteLine("Hello");};
            //action.Invoke();
            //Action<string> action2; // Generic [ 1 int Parameter - Void Return]
            //action2 = delegate(string X){ Console.WriteLine($"Hello {X}");};
            //action2.Invoke("Somaya");
            #endregion

            #region Ex10 [Lambda Expression] C# 3.0
            //// The Same As Anonymous Expression 
            //// But delete [delegate] then add [Fat Arrow] from [Parameter without ints data type]  To [built] / Return without Return KeyWord
            //Predicate<int> predicate = (x) => x > 0; ;
            //Console.WriteLine(predicate(4));

            //Func<int, string> func; // Fun ==> Take One Parameter [int] and Return [String]
            //func = (X) =>  X.ToString(); ;
            //Console.WriteLine(func(7)); // Casting From Int To String

            ////// Non Generic ==> Takes No Parameters and Return No Parameters
            //Action action; // Non Generic [0 Parameter - Void Return]
            ////action = delegate { Console.WriteLine("Hello"); }; // => Fat Arrow is invalid here Because of Zero Parameter 
            //// Or
            //action = () => Console.WriteLine("Hello");;
            //action.Invoke();
            //Action<string> action2; // Generic [ 1 int Parameter - Void Return]
            //action2 =  (X) => { Console.WriteLine($"Hello {X}"); };
            //action2.Invoke("Somaya");
            #endregion

            #region Ex11 [New Features At Delegate [var]] C# 10.0
            // C# is Strongly Type
            // Predicate<int> predicate = (X) => X > 0; 
            //var predicate = (int X) => X > 0; // Syntax Sugar Of Predicate
            //Console.WriteLine(predicate(4));

            //// Func<int, string> func = (X) => X.ToString();
            //var func = (int X) => X.ToString();

            //Console.WriteLine(func(4));

            ////Action action = () => Console.WriteLine("Hello");
            //var action = () => Console.WriteLine("Hello");
            //Console.WriteLine(action);

            #endregion

            #region Ex12 [List - Methods That Take Functions As Parameter]
            List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //// 1. Anonymous Function
            //// List<int> OddNumbers = Helper.GetElementBasedOnPassedFunction(Numbers, delegate(int X ) { return (X % 2 == 1); });

            //// 2. Lambda Expression [Recommended]
            //// List<int> OddNumbers = Helper.GetElementBasedOnPassedFunction(Numbers,  ( X) => X % 2 == 1);

            //// 3. FindAll
            //// List<int> OddNumbers = Numbers.FindAll(Number => Number % 2 == 1);
            //// Retreive All Elements That Match Condition
            ////foreach (int item in OddNumbers)
            ////    Console.WriteLine(item);

            //// 4. Find
            //int OddNumber = Numbers.Find(Number => Number % 2 == 1);
            //// First Element To Match In List
            //Console.WriteLine(OddNumber);
            
            //// 5. FindIndex
            //int index = Numbers.FindIndex(Number => Number % 2 == 1);
            //// Index of This Element that Match Condition
            //Console.WriteLine(index);
            
            //// 6. FindLast
            //int Last = Numbers.FindLast(Number => Number % 2 == 1);
            //// Last Element To Match In List
            //Console.WriteLine(Last);
            
            //// 7. FindLastIndex
            //int LastIndex = Numbers.FindLastIndex(Number => Number % 2 == 1);
            //// Index Of Last Element That Match Condition
            //Console.WriteLine(LastIndex);

            // 8. ForEach [Can't Update List]
            // Take An Action And Perform it on All Elements In List
            // Numbers.ForEach ( ( X) =>  X += 10 ); // Can't Change in List Using Foreach, it just used for Printing Only not Updating
            //Numbers.ForEach(X => Console.WriteLine(X +10));
            //foreach (int item in Numbers)
            //    Console.WriteLine(item);
            // 9. RemoveAll
            // Remove All Elements That Match Condition And Return Count Of Them 
            int Count = Numbers.RemoveAll(Number => Number % 5 == 0);
            Console.WriteLine($"The NUmber of Removed Elements = {Count}");
            foreach (int item in Numbers)
                Console.WriteLine(item);
            #endregion
            #endregion
            Console.ReadKey();
        }
    }

    class TestingFunctions
    {
        public static bool Test01 (int X)
        {
            return X > 0;
        }

        public static string Test02(int X)
        {
            return X.ToString();
        }

        public static void Test03()
        {
            Console.WriteLine("Hello");
        }

        public static void Test04(string X)
        {
            Console.WriteLine($"Hello {X}");
        }
    }
}
