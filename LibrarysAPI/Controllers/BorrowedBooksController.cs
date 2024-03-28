using LibrarysAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LibrarysAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowedBooksController : Controller
    {
        private readonly BorrowedBooksController dbContext;
        public BorrowedBooksController(BorrowedBooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
