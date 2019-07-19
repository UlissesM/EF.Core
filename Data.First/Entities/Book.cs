namespace Data.First.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual BookDetails BookDetails { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
