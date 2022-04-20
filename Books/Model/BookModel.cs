using System.ComponentModel.DataAnnotations;

namespace BookDB.Books
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageId { get; set; }
        public int MaxPages { get; set; }
        
        public int CurrentPages { get; set; }

        public BookModel(int id, string title, int imageId, int maxPages, int currentPages)
        {
            Id = id;
            Title = title;
            ImageId = imageId;
            MaxPages = maxPages;
            CurrentPages = currentPages;
        }

        public BookModel(string title, int imageId, int maxPages, int currentPages)
        {
            Title = title;
            ImageId = imageId;
            MaxPages = maxPages;
            CurrentPages = currentPages;
        }
    }
}
