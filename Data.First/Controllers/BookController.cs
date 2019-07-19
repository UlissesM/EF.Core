using Data.First.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Data.First.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepository _bookRepository;
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var resp = await _bookRepository.GetAll();
            return Ok(resp);
        }
    }
}
