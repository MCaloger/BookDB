using BookDB.Books;
using BookDB.Data;

namespace BookDBServer.Books
{
    public class BookRepository
    {
        private readonly DataContext dataContext;
        public BookRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public BookModel GetBook(int Id)
        {
            return dataContext.Books.Where<BookModel>(Book => Book.Id == Id).FirstOrDefault();
        }

        public List<BookModel> GetAllBooks()
        {
            return dataContext.Books.ToList();
        }

        public BookModel CreateBook(BookModel bookModel)
        {
            dataContext.Books.Add(bookModel);
            dataContext.SaveChanges();
            return bookModel;
        }

        public BookModel UpdateBook(BookModel bookModel)
        {
            dataContext.Books.Update(bookModel);
            dataContext.SaveChanges();
            return bookModel;
        }

        public BookModel UpdateBookById(int Id, BookModel bookModel)
        {
            BookModel? foundBook = dataContext.Books.FirstOrDefault(book => book.Id == Id);
            foundBook = bookModel;
            dataContext.Books.Update(foundBook);
            dataContext.SaveChanges();
            return foundBook;
        }

        public void DeleteBook(BookModel bookModel)
        {
            dataContext.Books.Remove(bookModel);
        }

        public void DeleteBookById(int Id)
        {
            BookModel? foundBook = dataContext.Books.FirstOrDefault(book => book.Id == Id);
            if (foundBook != null)
            {
                dataContext.Books.Remove(foundBook);
                dataContext.SaveChanges();
            }

        }
    }
}
