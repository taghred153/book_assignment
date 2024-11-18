using System.ComponentModel.DataAnnotations;

namespace book_assignment.Models
{
    public class Genre
    {
        [Key]
        public int GId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
