using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        public static int SummaryList(ArrayList arrayList)
        {
            int Sum = 0;
            if(arrayList != null)
            {
                for(int i = 0; i<arrayList.Count; i++ )
                {
                    Sum += (int)arrayList[i]; // Cast From Object To int
                                              // UnBoxing
                                              // Unsafe
                }
            }
            return Sum;
        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list != null)
            {
                foreach (int item in list)
                    Sum += item; // needn't to do Casting
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            #region Non Generic ArrayList
            ////ArrayList arrayList = new ArrayList(); // Empty Array
            //// Array Of Objects
            ////// arrarList => Size 0
            ////Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");
            ////// Count => Actual Number Of Elements In arrayList
            ////// Capacity => Number Of Elements Tha Can be Hold

            ////arrayList.Add(1);
            ////// Upon adding the first element to thr list tha capacity
            ////// increased to _defaultCapacity => 4 Bytes
            ////// Create new Arrat In Heap With Size 4
            ////Console.WriteLine("After Adding First Element: ");
            ////Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");

            ////arrayList.Add(2);

            ////Console.WriteLine("After Adding Second Element: ");
            ////Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");

            ////// Add in Range 
            ////arrayList.AddRange(new int[]{ 3 , 4});
            ////Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");

            ////arrayList.Add(5);
            ////// Create New Array At Heap With Double Size of old Array  [8]
            ////// Take Old Elements and Adding New Element To New Array
            ////Console.WriteLine("After Adding Fifth Element: ");
            ////Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");

            //ArrayList arrayList = new ArrayList(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");

            //arrayList.Add(6);
            //// Create New Array With Double Size Of Old Array ==> 10
            //Console.WriteLine("After Adding Sixth Element: ");
            //Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");

            //// 10 - 6 = 4 * [ Address Of Object] = 16 Bytes [Unused Bytes]
            //arrayList.TrimToSize(); // Deallocate || Free || Delete Unused Bytes
            //// Create New Array At Heap With Size = Count Of ArrayList
            //// Take Old Elements Of Old Array
            //// Old Array Now Is Unreachable Object

            //Console.WriteLine("After Trim: ");
            //Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of ArrayList = {arrayList.Capacity}");

            //arrayList.Add(1);
            //// Non Generic Collections
            //// Casting (1) Value Type To (Object) Reference Type [Boxing]

            //arrayList.Add("Somaya");
            ////// ArrayList ==> Heterogenous List

            //////foreach(int item in arrayList)
            //////{
            //////    Console.WriteLine(item); // Invalid Cast Exception
            //////}

            ////// Compiler Can Not Enforce Type Safety
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item); // Invalid Cast Exception
            //}

            //int Res= SummaryList(arrayList);
            //Console.WriteLine(Res);
            //// With Heterogenous List ==>  Compiler has No Problems, But CLR will be in Problems In Casting
            #endregion

            #region Generic
            #region List
            ////// List -> ArrayList New Version With Generics
            ////List<int> list = new List<int>();
            ////Console.WriteLine($"Count Of List = {list.Count}, Capacity Of List = {list.Capacity}");
            ////list.Add(1);
            ////// Upon adding the first element to the List the Capacity is
            ////// increased to DefaultCapacity = 4, 

            ////Console.WriteLine($"Count Of List = {list.Count}, Capacity Of List = {list.Capacity}");
            ////list.Add(2);
            ////list.AddRange(new List<int> { 3, 4 });
            ////Console.WriteLine($"Count Of List = {list.Count}, Capacity Of List = {list.Capacity}");

            ////list.Add(5);
            ////Console.WriteLine("After Adding Fifth Element: ");
            ////// Create new Array with Double Size of Old Array
            ////Console.WriteLine($"Count Of List = {list.Count}, Capacity Of List = {list.Capacity}");

            ////list.TrimExcess();
            ////// Create New Array With Size = Count Of Elements

            ////Console.WriteLine("After Trim: ");
            ////Console.WriteLine($"Count Of List = {list.Count}, Capacity Of List = {list.Capacity}");

            //List<int> list = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count Of List = {list.Count}, Capacity Of List = {list.Capacity}");

            //list.Add(6);
            //// Create New Array With Double Size Of Old Array
            //Console.WriteLine($"Count Of List = {list.Count}, Capacity Of List = {list.Capacity}");

            //foreach (int item in list)
            //    Console.WriteLine(item);
            //list[1] = 20; // Indexer To Set Value
            //for (int i = 0; i < list.Count; i++)
            //    Console.WriteLine(list[i]); // because it has indexer
            //                                // Using Indexer to Get Value
            //                                // We can Use Indexer to Set Value

            ////list[6] = 60; // Invalid // ArgumentOutOfRangeException
            //// You Can not use  Indexer Of List To Add Element
            //list.Add(60);
            ////list.Add("Somaya"); // Invalid 
            //int res = SumList(list);

            //Console.WriteLine(res);
            #endregion

            #region List Methods
            ////List<int> Numbers = new List<int>(4) { 1, 2, 3, 4 };
            ////Console.WriteLine($"Count Of Numbers = {Numbers.Count}, Capacity Of Numbers = {Numbers.Capacity}");
            ////Numbers.Add(5); // Add One Element
            ////Numbers.AddRange(new int[] { 6, 7 });
            ////Console.WriteLine($"Count Of Numbers = {Numbers.Count}, Capacity Of Numbers = {Numbers.Capacity}");
            ////foreach (int item in Numbers)
            ////    Console.Write($"{item} ");
            ////Numbers.Insert(6, 8); // Insert Element Into Specific Index
            ////Console.WriteLine("\n==================================");
            ////foreach (int item in Numbers)
            ////    Console.Write($"{item} ");
            ////Console.WriteLine("\n");
            ////Numbers.InsertRange(4, new int[] { 9, 10 });
            ////foreach (int item in Numbers)
            ////    Console.Write($"{item} ");
            ////Console.WriteLine($"\nCount Of Numbers = {Numbers.Count}, Capacity Of Numbers = {Numbers.Capacity}");

            ////int index = Numbers.BinarySearch(9);
            ////Console.WriteLine(index);
            ////// If Not Found return negative number of Coming Index + 1
            ////// Numbers.Clear(); // Remove All Elements in List
            ////Console.WriteLine($"\nCount Of Numbers = {Numbers.Count}, Capacity Of Numbers = {Numbers.Capacity}");
            ////// Counts = 0, Capacity = 16
            ////Console.WriteLine(Numbers.Contains(7));
            //List<int> Numbers = new List<int>(4) { 1, 2, 3, 4 };
            //int[] array = new int[10];
            ////Numbers.CopyTo(array); // 1 2 3 4
            //// The Size Of distination Should Be Greater Than Or Equal Source

            ////Numbers.CopyTo(array, 5); // Start Coping From Index 5
            //// 0 0 0 0 0 1 2 3 4 0
            //Numbers.CopyTo(1, array, 5 , 3); // 0 0 0 0 0 2 3 4 0 0 // Be Creful About OutOfRangeException
            //for (int i = 0; i < array.Length; i++)
            //    Console.WriteLine(array[i]);

            //// Numbers.EnsureCapacity(10); // Increase Capacity to this Number by Doubling Size then increase untill this number
            //Numbers.IndexOf(3); // The index of the first Occurence Of This Number
            //Numbers.LastIndexOf(3); // The Index Of The Last Occurrence of This Number

            //Numbers.Remove(3);
            //foreach (int item in Numbers)
            //    Console.Write($"{item} ");
            //Numbers.Reverse();
            #endregion

            #region LinkedList
            //LinkedList<int> Linkedlist = new LinkedList<int>(); // Head
            //// Console.WriteLine(Linkedlist.Count); // 0

            //Linkedlist.AddFirst(1);
            //Linkedlist.AddLast(2);
            //LinkedListNode <int>node= Linkedlist.Find(1);
            //Linkedlist.AddAfter(node, 5);
            //LinkedListNode<int> node2 = Linkedlist.Find(2);
            //Linkedlist.AddBefore(node2, 7);
            //// Console.WriteLine(Linkedlist.Count); // 1
            //foreach (int item in Linkedlist)
            //    Console.WriteLine(item);
            #endregion

            #region Generic Stack  [LIFO]
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine($"Peek: {stack.Peek()}");
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //// stack.Pop(); // Invalid // Throw Exception // Stack is Empty So We Use
            //bool Res = stack.TryPop(out int Element);
            //Console.WriteLine(Res);
            //foreach (int item in stack)
            //    Console.WriteLine(item);

            #endregion

            #region Generic Queue [FIFO]
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine($"Peek: {queue.Peek()}\n========================="); // Without Removing
            //queue.Dequeue();
            //bool flag = queue.TryDequeue(out int Element);
            //Console.WriteLine(flag);
            //bool f = queue.TryPeek(out int Element2);
            //Console.WriteLine(f);
            //Console.WriteLine($"Peek: {Element2}");
            //foreach (int item in queue)
            //    Console.WriteLine(item);
            #endregion
            #endregion
            Console.ReadKey();
        
        }
    }
}
