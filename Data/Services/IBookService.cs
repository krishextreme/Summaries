namespace Summaries.Data;

// Interface to get all the service details for the angular
public interface IBookService
{
    // to get all the book details 
    List<Book> GetAllBooks();

    // To get the book details by ID
    Book GetBookById(int id);

    //to update the book details by id
    void UpdateBook(int id, Book newBook);

    // to delete the book by id
    void DeleteBook(int id);

    // to add a new book 
    void AddBook(Book newBook);
}


