using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyLibrary.Models.OrderModels;
using MyLibrary.Models.ShoppingCartModels;

namespace MyLibrary.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required] 
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [Required] 
        public string? Description { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string ISBN { get; set; }
        public string? Image { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }

    }
}
