using BookApp.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public static class UserInputProcessor
    {
        public static string GetMenuChoice(List<string> options)
        {

            string menuChoice = Console.ReadLine();

            bool isValid = UserInputValidator.ValidateMenuChoice(menuChoice, options.Count);

            while (isValid == false)
            {
                MenuMessages.WrongChoice();
                menuChoice = Console.ReadLine();
                isValid = UserInputValidator.ValidateMenuChoice(menuChoice, options.Count);
            }

            return options[int.Parse(menuChoice) - 1];
        }

        public static string GetBookTitle()
        {

            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            bool isTitleValid = UserInputValidator.ValidateBookTitleOrAuthorInput(title);

            while (isTitleValid == false)
            {
                MenuMessages.InvalidTitleOrAuthorInput();
                if (isTitleValid == false)
                {
                    Console.WriteLine("Title:");
                }
                title = Console.ReadLine();
                isTitleValid = UserInputValidator.ValidateBookTitleOrAuthorInput(title);
            }

            return string.Join(" ", title.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }

        public static string GetBookAuthor()
        {

            Console.WriteLine("Author:");
            string author = Console.ReadLine();
            bool isAuthorValid = UserInputValidator.ValidateBookTitleOrAuthorInput(author);

            while (isAuthorValid == false)
            {
                MenuMessages.InvalidTitleOrAuthorInput();
                if (isAuthorValid == false)
                {
                    Console.WriteLine("Author:");
                }
                author = Console.ReadLine();
                isAuthorValid = UserInputValidator.ValidateBookTitleOrAuthorInput(author);
            }

            return string.Join(" ", author.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }

        public static string GetISBN()
        {

            Console.WriteLine("ISBN:");
            string isbn = Console.ReadLine();
            bool isIsbnValid = UserInputValidator.ValidateIsbn(isbn);

            while (isIsbnValid == false)
            {
                MenuMessages.InvalidISBN();
                if (isIsbnValid == false)
                {
                    Console.WriteLine("ISBN:");
                }
                isbn = Console.ReadLine();
                isIsbnValid = UserInputValidator.ValidateIsbn(isbn);
            }

            return isbn.Replace("-","");

        }

        public static int GetQuantity()
        {

            Console.WriteLine("Quantity:");
            string quantity = Console.ReadLine();
            bool isAmountValid = UserInputValidator.ValidateQuantity(quantity);

            while (isAmountValid == false)
            {
                MenuMessages.InvalidQuantity();
                if (isAmountValid == false)
                {
                    Console.WriteLine("Quantity:");
                }
                quantity = Console.ReadLine();
                isAmountValid = UserInputValidator.ValidateQuantity(quantity);
            }

            return int.Parse(quantity);
        }

        public static int GetQuantityToUpdateInventoryStock()
        {

            Console.WriteLine("Quantity:");
            string quantity = Console.ReadLine();
            bool isAmountValid = UserInputValidator.ValidateQuantityToUpdateStock(quantity);

            while (isAmountValid == false)
            {
                MenuMessages.InvalidQuantity();
                if (isAmountValid == false)
                {
                    Console.WriteLine("Quantity:");
                }
                quantity = Console.ReadLine();
                isAmountValid = UserInputValidator.ValidateQuantityToUpdateStock(quantity);
            }

            return int.Parse(quantity);
        }

        public static string GetSearchValue()
        {

            Console.WriteLine("Search for a book:");
            string searchterm = Console.ReadLine();
            bool isSearchtermValid = UserInputValidator.ValidateBookTitleOrAuthorInput(searchterm);

            while (isSearchtermValid == false)
            {
                MenuMessages.InvalidTitleOrAuthorInput();
                if (isSearchtermValid == false)
                {
                    Console.WriteLine("Search for a book:");
                }
                searchterm = Console.ReadLine();
                isSearchtermValid = UserInputValidator.ValidateBookTitleOrAuthorInput(searchterm);
            }

            return string.Join(" ", searchterm.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }
    }
}
