using BookApp.Menu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BookApp
{
    public class Inventory
    {
        //private List<Book>? _books = new List<Book>();

        public void AddBookToInventory(Book book)
        {
            DataAccess.AddBookDataToJson(book);            
        }

        public List<Book> SearchForBook(string searchString)
        {
            var foundBooks = DataAccess.SearchBookInJson(searchString);

            return foundBooks;

        }

        public void UpdateBookQuantity(string isbn, int quantity)
        {
            DataAccess.UpdateBookQuantityInJson(isbn, quantity);
        }

        public void DeleteBook(string isbn)
        {
            DataAccess.DeleteBookFromJson(isbn);
        }

    }

    
}
