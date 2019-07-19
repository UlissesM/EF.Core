using Code.First.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Code.First.Controllers
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
        public IActionResult Get()
        {
            return Ok(_bookRepository.GetAll());
        }
    }
}
