using BookStore1.core;
using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace BookStore1.Core
{
    public class DBClient : IDClient
    {
        private readonly IMongoCollection<Book> _books;
        public DBClient(IOptions<BookStoreDb> bookstoreDb) {

            var client = new MongoClient(bookstoreDb.Value.Connection_String);
            var database = client.GetDatabase(bookstoreDb.Value.Db_Name);
            _books = database.GetCollection<Book>(bookstoreDb.Value.Book_Collection_Name);

        }
        public IMongoCollection<Book> GetBooksCollection()
        {
            return _books;
        }
    }
}
