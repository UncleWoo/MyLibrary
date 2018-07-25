using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyLibrary.Models;

namespace MyLibrary.Controllers
{
    public class BookController : ApiController
    {
        private MyLibraryContext context = new MyLibraryContext();

        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            var books = context.Books.ToList();

            return books;
        }

        [HttpGet]
        public Book GetBookById(int id)
        {
            Book book = context.Books.Find(id);

            if (book == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return book;
        }
    }
}
