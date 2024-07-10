using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Menu
{
    public static class MenuMessages
    {
        public static void WrongChoice()
        {
            Console.WriteLine("You have entered an invalid choice");
        }

        public static void InvalidTitleOrAuthorInput()
        {
            Console.WriteLine("You have entered something invalid, please try again. Do not enter something blank or too long that exceeds 50 characters or any digits or special characters such as !,#,~ etc.");
        }

        public static void InvalidISBN()
        {
            Console.WriteLine("You have entered something invalid, please try again. Do not enter something blank, too short or too long.");

        }

        public static void InvalidQuantity()
        {
            Console.WriteLine("You have entered an invalid quantity. Please do not enter something blank or less than 0.");
        }

        public static void SearchResults(List<Book> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Found no books with that search term.");
                return;
            }

            Console.WriteLine($"Found {books.Count} results");
            foreach (var book in books)
            {
                Console.WriteLine();
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Isbn: {book.ISBN}");
                Console.WriteLine($"Quantity: {book.Quantity}");
                Console.WriteLine();
            }
        }

        public static void BookNotFound()
        {
            Console.WriteLine("Book not found. You may have entered the wrong isbn code");
        }

        public static void BookDeletionSuccesfull()
        {
            Console.WriteLine("Succesfully deleted book.");
        }

        public static void BookUpdateQuantityErrorMsg()
        {
            Console.WriteLine("Cant update book quantity to less than 0. Enter a different quantity to update.");

        }

        public static void BookAdded()
        {
            Console.WriteLine("Book succesfully added");
        }

        public static void BookNotAdded()
        {
            Console.WriteLine("Book already exists in inventory");

        }
    }
}
