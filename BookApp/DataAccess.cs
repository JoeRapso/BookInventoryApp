using BookApp.Menu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public static class DataAccess
    {
        public static void AddBookDataToJson(Book book)
        {
            string fileName = "C:\\My Projects\\BookApp\\BookApp\\Data\\Books.json";
            string jsonString = File.ReadAllText(fileName);
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonString);

            var bookInInventory = books.Where(b => b.ISBN.Equals(book.ISBN)).FirstOrDefault();

            if (bookInInventory == null)
            {
                books.Add(book);
                jsonString = JsonConvert.SerializeObject(books, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, jsonString);
                MenuMessages.BookAdded();
            }
            else
            {
                MenuMessages.BookNotAdded();
            }

        }

        public static List<Book> SearchBookInJson(string searchTerm)
        {
            List<Book> foundBooks = new List<Book>();

            string fileName = "C:\\My Projects\\BookApp\\BookApp\\Data\\Books.json";
            string jsonString = File.ReadAllText(fileName);
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonString);


            foreach (Book book in books)
            {
                if (book.Title == searchTerm || book.Author == searchTerm)
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }

        public static void UpdateBookQuantityInJson(string isbn, int quantity)
        {
            string fileName = "C:\\My Projects\\BookApp\\BookApp\\Data\\Books.json";
            string jsonString = File.ReadAllText(fileName);
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonString);

            var updatedBook = books.Where(x => x.ISBN.Equals(isbn)).FirstOrDefault();
        

            if (updatedBook == null)
            {
                MenuMessages.BookNotFound();
                return;
            }
            else if (updatedBook.Quantity + quantity < 0)
            {
                MenuMessages.BookUpdateQuantityErrorMsg();
                return;
            }


            updatedBook.Quantity += quantity;
            jsonString = JsonConvert.SerializeObject(books, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileName, jsonString);
        }

        public static void DeleteBookFromJson(string isbn)
        {
            string fileName = "C:\\My Projects\\BookApp\\BookApp\\Data\\Books.json";
            string jsonString = File.ReadAllText(fileName);
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonString);

            var bookToDelete = books.Where(x => x.ISBN.Equals(isbn)).FirstOrDefault();

            if (bookToDelete == null)
            {
                MenuMessages.BookNotFound();
                return;
            }
            else
            {
                foreach (Book book in books)
                {
                    if (book.ISBN == isbn)
                    {
                        books.Remove(book);
                        break;
                    }
                }
                jsonString = JsonConvert.SerializeObject(books, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, jsonString);

                MenuMessages.BookDeletionSuccesfull();
            }
        }
    }
}
