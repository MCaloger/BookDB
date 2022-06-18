using BookDB.Books.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Books
{
    [Route("api/v1/[controller]")]
    [ApiController]
    
    public class BookController : ControllerBase
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("books")]
        public ActionResult<IEnumerable<BookModel>> GetBooks()
        {
            return bookService.GetAllBooks();
        }

        [HttpGet("{Id}")]
        public ActionResult<BookModel> GetBook(int Id)
        {
            return bookService.GetBook(Id);
        }

        [HttpPost("create")]
        public ActionResult<BookModel> CreateBook(BookModel bookModel)
        {
            return bookService.CreateBook(bookModel);
        }

        [HttpPut("update")]
        public ActionResult<BookModel> UpdateBook(BookModel bookModel)
        {
            return bookService.UpdateBook(bookModel);
        }

        [HttpDelete("delete/{Id}")]
        public ActionResult DeleteBookById(int Id)
        {
            bookService.DeleteBookById(Id);
            return Ok();
        }
    }
}
