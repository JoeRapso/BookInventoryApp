using BookApp;

namespace UnitTests
{
    public class Tests
    {
        
        [Test]
        public void SearchingForSpecificBook_ReturnsCorrectResult()
        {
            

            var inventory = new Inventory();
            string searchTerm = "Meditations";

            var result = inventory.SearchForBook(searchTerm);

            Assert.That(result[0].Title, Is.EqualTo("Meditations"));


        }

        [Test]
        public void UpdatingBookQuantity_UpdatesCorrectly()
        {
            var inventory = new Inventory();

            string isbn = "";
            int quantity = 10;

            inventory.UpdateBookQuantity(isbn, quantity);
            var books = inventory.SearchForBook("The Order of the Phoenix");

            int newQuantityResult = 120;


            Assert.That(books[0].Quantity, Is.EqualTo(newQuantityResult));




        }

        [Test]
        public void AddingBook_AddsCorrectlyToJson()
        {
            var inventory = new Inventory();
            Book book = new Book("This is a test", "test author", "12910891913", 10);
            inventory.AddBookToInventory(book);
            var books = inventory.SearchForBook("This is a test");

            string newIsbnInJson = "12910891913";

            Assert.That(books[0].ISBN, Is.EqualTo(newIsbnInJson));


        }
    }
}