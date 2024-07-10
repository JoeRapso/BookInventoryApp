using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class Book
    {
        public string Title { get; init; }
        public string Author { get; init; }
        public string ISBN { get; init; }
        public int Quantity { get; set; }

        public Book(string title, string author, string isbn, int quantity) 
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Quantity = quantity;

        }

    }
}
