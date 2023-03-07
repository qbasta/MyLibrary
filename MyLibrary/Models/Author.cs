using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models
{
    [Table("Author")]
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? AuthorName { get; set; }

        public List<Book> Books { get; set; }
    }
}
