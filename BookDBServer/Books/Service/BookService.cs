using BookDBServer.Books;

namespace BookDB.Books.Service
{
    public class BookService
    {
        private readonly BookRepository bookRepository;
        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public BookModel GetBook(int Id)
        {
            return bookRepository.GetBook(Id);
        }

        public List<BookModel> GetAllBooks()
        {
            return bookRepository.GetAllBooks();
        }

        public BookModel CreateBook(BookModel bookModel)
        {
            return bookRepository.CreateBook(bookModel);
        }

        public BookModel UpdateBook(BookModel bookModel)
        {
            return bookRepository.UpdateBook(bookModel);
        }

        public BookModel UpdateBookById(int Id, BookModel bookModel)
        {
            return bookRepository.UpdateBookById(Id, bookModel);
        }

        public void DeleteBook(BookModel bookModel)
        {
            bookRepository.DeleteBook(bookModel);
        }

        public void DeleteBookById(int Id)
        {
            bookRepository.DeleteBookById(Id);
        }
    }
}
