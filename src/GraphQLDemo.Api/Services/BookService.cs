using GraphQLDemo.Api.Models;

namespace GraphQLDemo.Api.Services;

public class BookService
{
    private readonly List<Book> _books = new()
    {
        new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008 },
        new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 1999 }
    };

    public IEnumerable<Book> GetBooks() => _books;
    public Book? GetBook(int id) => _books.FirstOrDefault(b => b.Id == id);
    public Book AddBook(string title, string author, int year)
    {
        var book = new Book { Id = _books.Count + 1, Title = title, Author = author, Year = year };
        _books.Add(book);
        return book;
    }
}
