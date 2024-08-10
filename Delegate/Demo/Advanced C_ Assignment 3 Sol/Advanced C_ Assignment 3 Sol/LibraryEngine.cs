using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__Assignment_3_Sol
{
    // public delegate string BookFunctionDelegate(Book book);
    public class LibraryEngine
    {

        //public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fptr)
        //{
        //    foreach(Book B in bList)
        //    {
        //        Console.WriteLine(fptr(B));
        //    }
        //}

        public static void ProcessBooks(List<Book> bList, Func<Book, string> fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
}
