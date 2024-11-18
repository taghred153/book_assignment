using book_assignment.DTOs;

namespace book_assignment.Repository.Bookrepo
{
    public interface Ibookrepo
    {
        public BookDTO Getbyid(int id);
        public List<BookToReturnDTO> GetAll();
        public BookDTO  Add(BookDTO bookDTO);
        public BookDTO Update(BookDTO bookDTO);
        public BookDTO Delete(int id);
    }
}
