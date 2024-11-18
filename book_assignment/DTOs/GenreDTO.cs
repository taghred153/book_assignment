using System.ComponentModel.DataAnnotations;

namespace book_assignment.DTOs
{
    public class GenreDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
