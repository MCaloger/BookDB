using BookDB.Books;
using Microsoft.EntityFrameworkCore;

namespace BookDB.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
