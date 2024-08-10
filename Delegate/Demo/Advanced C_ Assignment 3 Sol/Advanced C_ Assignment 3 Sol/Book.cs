using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__Assignment_3_Sol
{
    public class Book
    { 
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string [] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            return $"The Book ISBN = {ISBN}, Title = {Title}, PublicationDate = {PublicationDate}, Price = {Price}, Authors = {String.Join("-",Authors)}";
        }
    }
}
