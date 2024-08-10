using System;
using System.Collections.Generic;

namespace Advanced_C__Assignment_3_Sol
{
    // public delegate string BookFunctionDelegate(Book book);
    class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            string isbn1 = "978-3-16-148410-0";
            string title1 = "The Great Gatsby";
            string[] authors1 = { "F. Scott Fitzgerald" };
            DateTime publicationDate1 = new DateTime(1925, 4, 10);
            decimal price1 = 10.99m;
            Book book1 = new Book(isbn1, title1, authors1, publicationDate1, price1);

            string isbn2 = "911-99-88-27-16-756";
            string title2 = "Atomic Habits";
            string[] authors2 = { "F. Scott Fitzgerald" , "James Clear"};
            DateTime publicationDate2 = new DateTime(1990, 7, 20);
            decimal price2 = 55.99m;
            Book book2 = new Book(isbn2, title2, authors2, publicationDate2, price2);

            List<Book> BookList = new List<Book>();
            BookList.Add(book1);
            BookList.Add(book2);
            #region User-Defined Delegate
            //LibraryEngine.ProcessBooks(BookList , BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(BookList, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooks(BookList, BookFunctions.GetPrice);
            #endregion

            #region Built-In DataType
            //LibraryEngine.ProcessBooks(BookList, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(BookList, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooks(BookList, BookFunctions.GetPrice);
            #endregion

            #region Anonymous Method [ISBN]
            //LibraryEngine.ProcessBooks(BookList, delegate (Book book) { return book.ISBN; });
            #endregion

            #region Lambda Method [PublicationDate]
            //LibraryEngine.ProcessBooks(BookList, (book) => (book.PublicationDate).ToString());
            #endregion
            #endregion

            #region Part02
            //ListFromScratch<int> listFromScratch = new ListFromScratch<int>();
            //listFromScratch.Add(3);
            //listFromScratch.Add(1);
            //listFromScratch.Add(11);
            //listFromScratch.Add(-1);
            //listFromScratch.Add(10);
            //listFromScratch.Add(8);
            //listFromScratch.Add(1);
            //listFromScratch.Add(10);

            //Console.Write("Exist: ");
            //Console.WriteLine(listFromScratch.Exist(Num => Num > 10));

            //Console.Write("Find: ");
            //Console.WriteLine(listFromScratch.Find(Num => Num > 3));

            //Console.Write("FindAll: \n");
            //List<int> fromScratch = listFromScratch.FindAll(Num => Num > 3);
            //foreach (int item in fromScratch)
            //    Console.WriteLine(item);

            //Console.Write("FindIndex: ");
            //Console.WriteLine(listFromScratch.FindIndex(Num => Num > 3));

            //Console.Write("FindLast: ");
            //Console.WriteLine(listFromScratch.FindLast(Num => Num > 3));

            //Console.Write("FindLastIndex: ");
            //Console.WriteLine(listFromScratch.FindLastIndex(Num => Num > 3));

            //Console.WriteLine("ForEach: ");
            //listFromScratch.ForEach(X => Console.WriteLine(X + 10));

            //Console.WriteLine("TrueForAll: ");
            //Console.WriteLine(listFromScratch.TrueForAll(Num => Num > -2));
            #endregion

            Console.ReadKey();
        }
    }
}
