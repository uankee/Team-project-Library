namespace BusinessLogic.Configurations.DTOs.BookDto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AvailableCopies { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string? AuthorName { get; set; }
        public string? GenreName { get; set; }
    }
}
