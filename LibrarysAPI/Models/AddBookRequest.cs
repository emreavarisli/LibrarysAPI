namespace LibrarysAPI.Models
{
    public class AddBookRequest
    {
        public string BookName { get; set; } 
        public string Author { get; set; } 
        public int ISBN { get; set; }
        public string Genre { get; set; } 
        public string PublicationDate { get; set; } 
    }
}
