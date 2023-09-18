using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore1.core
{
    public interface IBookServicescs
    {
        List<Book> GetBooks();
        Book AddBook(Book book);
    }
}
