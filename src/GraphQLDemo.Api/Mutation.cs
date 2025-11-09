using GraphQLDemo.Api.Models;
using GraphQLDemo.Api.Services;

namespace GraphQLDemo.Api.GraphQL;

public class Mutation
{
    public Book AddBook([Service] BookService service, string title, string author, int year)
        => service.AddBook(title, author, year);
}
