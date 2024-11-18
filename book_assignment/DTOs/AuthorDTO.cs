using System.ComponentModel.DataAnnotations;

namespace book_assignment.DTOs
{
    public class AuthorDTO
    {
        [Required]
        public string Name { get; set; }
        [Phone(ErrorMessage = "Enter Valid number")]
        public string? phone { get; set; }

        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string? email { get; set; }
    }
}
