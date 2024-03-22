using LibrarysAPI.Data;
using LibrarysAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrarysAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly BooksDbContext dbContext;
        public BooksController(BooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            return Ok(await dbContext.Books.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBooks([FromRoute] int id)
        {
            var book = await dbContext.Books.FindAsync(id);
            
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBooks(AddBookRequest addBookRequest)
        {
            var book = new Book()
            {
                BookName = addBookRequest.BookName,
                Author = addBookRequest.Author,
                ISBN = addBookRequest.ISBN,
                Genre = addBookRequest.Genre,
                PublicationDate = addBookRequest.PublicationDate,
            };

            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();

            return Ok(book);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateBooks([FromRoute] int id, UpdateBookRequest updateBookRequest)
        {
            var book = await dbContext.Books.FindAsync(id);

            if(book != null)
            {
                book.BookName = updateBookRequest.BookName;
                book.Author = updateBookRequest.Author;
                book.ISBN = updateBookRequest.ISBN;
                book.Genre = updateBookRequest.Genre;
                book.PublicationDate = updateBookRequest.PublicationDate;

                await dbContext.SaveChangesAsync();

                return Ok(book);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteBooks([FromRoute] int id)
        {
            var book = await dbContext.Books.FindAsync(id);

            if (book != null)
            {
                dbContext.Remove(book);
                dbContext.SaveChanges();
                return Ok(book);
            }

            return NotFound();
        }
    }
}
