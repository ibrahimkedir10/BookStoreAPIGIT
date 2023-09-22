using Bookstore.core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBookstore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;

        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookServices.GetBooks());


        }
        [HttpGet("{id}", Name = "GetBook")]
        public IActionResult GetBook(string id)
        {
            return Ok(_bookServices.GetBook(id));
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookServices.AddBook(book);
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(string id)
        {
            _bookServices.DeletBook(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book) 
        {
            return Ok(_bookServices.UpdateBook(book));
        }
    }
}
