using Bookstore.core;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Bookstore.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> _books;

        public DbClient(Microsoft.Extensions.Options.IOptions<BookstoreDbConfig> bookstoreDbConfig)
        {
            var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookstoreDbConfig.Value.Database_Name);
            _books = database.GetCollection<Book>(bookstoreDbConfig.Value.Books_Collection_Name); // Replace "Books" with your actual collection name
        }

        public IMongoCollection<Book> GetBooksCollection()
        {
            return _books;
        }
    }
}
