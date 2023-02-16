using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
