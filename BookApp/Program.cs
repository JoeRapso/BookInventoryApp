
using BookApp;
using BookApp.Menu;

var inventory = new Inventory();
List<string> menuChoices = new List<string>() { "Add Book To Inventory", "Update Book Quantity", "Search for a Book", "Delete Book", "Exit" };

bool userExited = false;
while (!userExited)
{
    MenuText.MainMenu(menuChoices);
    string menuChoice = UserInputProcessor.GetMenuChoice(menuChoices);

    if(menuChoice == "Add Book To Inventory")
    {
        

        string bookTitle = UserInputProcessor.GetBookTitle();
        string bookAuthor = UserInputProcessor.GetBookAuthor();
        string isbn = UserInputProcessor.GetISBN();
        int quantity = UserInputProcessor.GetQuantity();

        Book book = new Book(bookTitle, bookAuthor, isbn, quantity);

        inventory.AddBookToInventory(book);
    }
    else if(menuChoice == "Update Book Quantity")
    {
        string isbn = UserInputProcessor.GetISBN();
        int quantity = UserInputProcessor.GetQuantityToUpdateInventoryStock();
        inventory.UpdateBookQuantity(isbn, quantity);

    }
    else if (menuChoice == "Search for a Book")
    {
        string searchString = UserInputProcessor.GetSearchValue();
        var foundBooks = inventory.SearchForBook(searchString);

        MenuMessages.SearchResults(foundBooks);

        
    }
    else if (menuChoice == "Delete Book")
    {
        string isbn = UserInputProcessor.GetISBN();
        inventory.DeleteBook(isbn);

    }
    else if(menuChoice == "Exit")
    {
        userExited = true;
    }
}
//var book1 = new Book("test", "testtitle", "111231");
//var book2 = new Book("test2", "testtitle2", "111232");//{ Author = "test", Title = "testtitle", ISBN = "11231sss" };

//book1.Quantity = 1;

////inventory.books.Add(book1);

////inventory.books.Add(book2);

////inventory.books[1].Quantity = 10;

//inventory.AddBookToInventory(book1);
//inventory.AddBookToInventory(book2);
//inventory.AddBookToInventory(book1);

//book1.Quantity += 81;

//var s = inventory.SearchForBook("test", "testtitle");

//Console.WriteLine("s");

//books[0].ISBN = "s4";
