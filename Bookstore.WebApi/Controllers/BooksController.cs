using BookStore1.core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookServicescs _bookServices;
        public BooksController(IBookServicescs bookServices)
        {
            _bookServices = bookServices;  
        }

        [HttpGet]
        public IActionResult GetBooks() 
        {
            return Ok(_bookServices.GetBooks());
        }
        [HttpPost]
        public IActionResult AddBook(Book book) {
            _bookServices.AddBook(book);
            return Ok(book);
        }
    }
}
