using BookStore1.Core;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace BookStore1.core
{
    public class BookServices : IBookServicescs
    {
        private readonly IMongoCollection<Book> _books;
        public BookServices(IDClient dbclient) {

            _books = dbclient.GetBooksCollection();
        }

        public Book AddBook(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public List<Book> GetBooks() => _books.Find(book => true).ToList();// returns all books from book.cs


    }
}
