using System.Collections.Generic;

namespace Code.First.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
