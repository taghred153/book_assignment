using book_assignment.DTOs;

namespace book_assignment.Repository.Authorrpo
{
    public interface Iauthorrepo
    {
        public AuthorDTO Getbyid(int id);
        public List<AuthorDTO> GetAll();
        public AuthorDTO Add(AuthorDTO AuthorDTO);
        public AuthorDTO Update(AuthorDTO AuthorDTO);
        public AuthorDTO Delete(int id);
    }
}
