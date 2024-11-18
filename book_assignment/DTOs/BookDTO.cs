using System.ComponentModel.DataAnnotations;

namespace book_assignment.DTOs
{
    public class BookDTO
    {
        [Required]
        public string Title { get; set; }
        public DateTime publishedyear { get; set; }

        public List<int> Authorid { get; set; }   // عشان انا عايزه اعمل access علي author جوه ال book
        public List<int> genreid { get; set; }
    }


    public class BookToReturnDTO
    {
        [Required]
        public string Title { get; set; }
        public DateTime publishedyear { get; set; }

        public List<AuthorDTO> Authors { get; set; }   // عشان انا عايزه اعمل access علي author جوه ال book
        public List<GenreDTO> genres { get; set; }
    }
}
