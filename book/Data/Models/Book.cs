namespace book.Data.Models
{
    public class Book
    {
//fdgsgsgsgsgsdg
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isRead { get; set; }
        public int? Rate { get; set; }
        public DateTime DateRead { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Navigation property
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set;  }

        public List<Author> Auhtors { get; set; }
    }
}
