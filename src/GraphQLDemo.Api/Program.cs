using GraphQLDemo.Api.GraphQL;
using GraphQLDemo.Api.Services;
using HotChocolate.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Dipendenze
builder.Services.AddSingleton<BookService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);

var app = builder.Build();

// Endpoint GraphQL
app.MapGraphQL("/graphql");

// Homepage
app.MapGet("/", () => "GraphQL Demo API running...");

// Playground (Banana Cake Pop)
app.UsePlayground(new HotChocolate.AspNetCore.Playground.PlaygroundOptions
{
    QueryPath = "/graphql",
    Path = "/playground"
});

app.Run();
