using System.ComponentModel.DataAnnotations;

namespace BookDB.Books
{
    public class BookModel
    {
        [Key]
        public int? Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public int? ImageId { get; set; }
        public int? MaxPages { get; set; }
        public int? CurrentPages { get; set; }

        public BookModel()
        {
        }

        public BookModel(int id, string title, string? author, int? imageId, int? maxPages, int? currentPages)
        {
            Id = id;
            Title = title;
            Author = author;
            ImageId = imageId;
            MaxPages = maxPages;
            CurrentPages = currentPages;
        }

        public BookModel(string title, string? author, int? imageId, int? maxPages, int? currentPages)
        {
            Title = title;
            Author = author;
            ImageId = imageId;
            MaxPages = maxPages;
            CurrentPages = currentPages;
        }
    }
}
