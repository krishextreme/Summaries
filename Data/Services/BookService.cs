using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summaries.Data;

public class BookService : IBookService
{
    // refer IBookService.AddBook
    public void AddBook(Book newBook)
    {
        Data.Books.Add(newBook);
    }

    public void DeleteBook(int id)
    {
        var book = Data.Books.FirstOrDefault(myBook => myBook.Id.Equals(id));

        if (book != null)
            Data.Books.Remove(book);
    }

    public List<Book> GetAllBooks()
    {
        return Data.Books.ToList();
    }

    public Book GetBookById(int id)
    {
        var myBook = Data.Books.FirstOrDefault(myBook => myBook.Id.Equals(id));
        return myBook;
    }

    // to update the book id
    public void UpdateBook(int id, Book newBook)
    {
        var oldBook = Data.Books.FirstOrDefault(myBook => myBook.Id.Equals(id));

        if (oldBook != null)
        {
            oldBook.Title = newBook.Title;
            oldBook.Author = newBook.Author;
            oldBook.Description = newBook.Description;
            oldBook.Rate = newBook.Rate;
            oldBook.DateStart = newBook.DateStart;
            oldBook.DateRead = newBook.DateRead;
        }
    }
}
