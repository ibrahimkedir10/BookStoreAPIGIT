using BookStore1.core;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore1.Core
{
    public interface IDClient
    {
        IMongoCollection<Book>GetBooksCollection();
    }
}
