using BookDB.Books.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Books
{
    [Route("api/v1/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("/")]
        public ActionResult<IEnumerable<BookModel>> GetBooks()
        {
            return bookService.GetAllBooks();
        }

        [HttpGet("/{id}")]
        public ActionResult<BookModel> GetBook(int id)
        {
            return bookService.GetBook(id);
        }

        [HttpPost("/create")]
        public ActionResult<BookModel> CreateBook(BookModel bookModel)
        {
            return bookService.CreateBook(bookModel);
        }

        [HttpPost("/update")]
        public ActionResult<BookModel> UpdateBook(BookModel bookModel)
        {
            return bookService.UpdateBook(bookModel);
        }

        [HttpPost("/delete")]
        public ActionResult DeleteBook(BookModel bookModel)
        {
            bookService.DeleteBook(bookModel);
            return Ok();
        }
    }
}
