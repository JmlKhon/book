using System.ComponentModel.DataAnnotations;

namespace book.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }

        //Navigation Properties
        public List<Book> Book_Authors { get; set; }
    }
}
