using GraphQLDemo.Api.Models;
using GraphQLDemo.Api.Services;

namespace GraphQLDemo.Api.GraphQL;

public class Query
{
    public IEnumerable<Book> GetBooks([Service] BookService service) => service.GetBooks();
    public Book? GetBook([Service] BookService service, int id) => service.GetBook(id);
}
