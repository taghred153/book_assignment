using book_assignment.DTOs;

namespace book_assignment.Repository.Genrerepo
{
    public interface Igenrerepo
    {
        public GenreDTO Getbyid(int id);
        public List<GenreDTO> GetAll();
        public GenreDTO Add(GenreDTO GenreDTO);
        public GenreDTO Update(GenreDTO GenreDTO);
        public GenreDTO Delete(int id);
    }
}
