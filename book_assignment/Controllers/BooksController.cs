using book_assignment.DTOs;
using book_assignment.Repository.Bookrepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace book_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly Ibookrepo _repo;
        public BooksController(Ibookrepo ibookrepo)
        {
            _repo = ibookrepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var book = _repo.GetAll();
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public IActionResult AddBook(BookDTO bookDTO)
        {
            var books = _repo.Add(bookDTO);
            if (books == null)
            {
                return NotFound();
            }
            return Created();
        }

    }
}
