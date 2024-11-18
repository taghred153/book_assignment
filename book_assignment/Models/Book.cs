using System.ComponentModel.DataAnnotations;

namespace book_assignment.Models
{
    public class Book
    {
        [Key]
        public int BId { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime publishedyear { get; set; }
        public ICollection<Author>? authors { get; set; }
        public ICollection<Genre>? genres { get; set; }
    }
}
