using BookDB.Data;

namespace BookDB.Books.Service
{
    public class BookService
    {
        private readonly DataContext dataContext;
        public BookService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public BookModel GetBook(int Id)
        {
            return (BookModel)dataContext.Books.Where<BookModel>(Book => Book.Id == Id);
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

        public void DeleteBook(BookModel bookModel)
        {
            dataContext.Books.Remove(bookModel);
        }

        public void DeleteBook(int Id)
        {
            BookModel FoundBook = dataContext.Books.FirstOrDefault(book => book.Id == Id);
            dataContext.Books.Remove(FoundBook);
        }
    }
}
