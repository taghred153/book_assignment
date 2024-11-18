using book_assignment.Data;
using book_assignment.DTOs;
using book_assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace book_assignment.Repository.Bookrepo
{
    public class bookrepo : Ibookrepo
    {
        private readonly AppDbContext _context; // محدش يقدر ي access من بره ال class
        public bookrepo(AppDbContext context)
        {
            _context = context; //use dependency injection
        }

        public BookDTO Add(BookDTO bookDTO)
        {
            var authors = _context.Authors.Where(a=>bookDTO.Authorid.Contains(a.AId)).ToList();
            //contains زي ==
            //عشان هي list فبقارن ب Contains بدل ==
            //where عشان ابحث بال list كاني بعمل search
            var gene = _context.Genres.Where(a=>bookDTO.genreid.Contains(a.GId)).ToList();

            var book = new Book
            {
                 Title = bookDTO.Title,
                 publishedyear = bookDTO.publishedyear,
                 authors = authors,
                 genres = gene,
            };
            if(bookDTO == null)
            {
                return null;
            }
            _context.Books.Add(book);
            _context.SaveChanges();
            return bookDTO;
        }

        public BookDTO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookToReturnDTO> GetAll()
        {
            //select = for loop
            //هعمل select من ال book واحطه في bookdto
            // جوه العكس add بعمل
            var books = _context.Books.Include(b=> b.authors).Include(b=> b.genres)
                .Select(b => new BookToReturnDTO
            {
                Title = b.Title,
                publishedyear = b.publishedyear,
                Authors = b.authors.Select(x => new AuthorDTO
                {
                    Name = x.Name,
                    email = x.email,
                    phone = x.phone,
                }).ToList(),

                genres = _context.Genres.Select(c => new GenreDTO
                {
                    Name= c.Name,
                }).ToList(),

            }).ToList();

            return books;

        }

        public BookDTO Getbyid(int id)
        {
            var book = _context.Books.Find(id);

        }

        public BookDTO Update(int Id, BookDTO bookDTO)
        {
            var book = _context.books.Find(Id);
            if (book == null) return null;
            book.Title = bookDTO.Title;
            book.PublishedYear = bookDTO.publishedyear;
            if (bookDTO.Authorid.Count() > 0)
            {
                book.Authors = _context.Authors.Where(a => bookDto.AuthorId.Contains(a.Id)).ToList();
            }
            if (bookDTO.genreid.Count() > 0)
            {
                book.Genres = _context.Genres.Where(a => bookDTO.genreid.Contains(a.Id)).ToList();
            }
            _context.Update(book);
            _context.SaveChanges();

            return bookDTO;
        }

    }
}