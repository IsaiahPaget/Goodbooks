using GoodBooks.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using GoodBooks.Data;
using GoodBooks.Data.Models;
using GoodBooks.Web.RequestModels;

namespace GoodBooks.Web.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookService _bookService;

        public BooksController(ILogger<BooksController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet("api/books")]
        public ActionResult Get()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpPost("api/books")]
        public ActionResult Get([FromBody] NewBookRequest bookRequest)
        {
            var now = DateTime.UtcNow;
            var book = new Book
            {
                CreatedOn = now,
                UpdateOn = now,
                Title = bookRequest.Title,
                Author = bookRequest.Author
            };

            _bookService.SaveBook(book);

            return Ok($"created book: {book.Title}");
        }
    }
}
