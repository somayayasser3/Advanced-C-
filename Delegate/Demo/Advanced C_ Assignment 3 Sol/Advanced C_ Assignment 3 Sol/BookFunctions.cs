using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__Assignment_3_Sol
{ 
    public class BookFunctions
    {
        public static string GetTitle(Book B )
        {
            return $"The Book Title: {B.Title}";
        }

        public static string GetAuthors(Book B)
        {
            return $"The Book Authors: {String.Join("-", B.Authors)}";
        }

        public static string GetPrice(Book B)
        {
            return $"The Book Price = {B.Price.ToString()}";
        }

    }
}
