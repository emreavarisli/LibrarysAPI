using LibrarysAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrarysAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowedBooksController : Controller
    {
        private readonly BorrowedBooksDbContext dbContext;
        public BorrowedBooksController(BorrowedBooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            return Ok(await dbContext.BorrowedBooks.ToListAsync());
        }
    }
}
