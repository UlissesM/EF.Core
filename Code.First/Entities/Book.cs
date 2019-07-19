namespace Code.First.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public int PageNumbers { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public bool IsAvailable { get; set; }
    }
}
