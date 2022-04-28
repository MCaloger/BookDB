using System.ComponentModel.DataAnnotations;

namespace BookDB.Books
{
    public class BookModel
    {
        [Key]
        public int? Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? Image { get; set; }

        public BookModel()
        {
        }

        public BookModel(int? id, string title, string? author, string? image)
        {
            Id = id;
            Title = title;
            Author = author;
            Image = image;
        }

        public BookModel(string title, string? author, string? image)
        {
            Title = title;
            Author = author;
            Image = image;
        }
    }
}
