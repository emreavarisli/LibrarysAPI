namespace LibrarysAPI.Models
{
    public class AddBorrowedBookRequest
    {
        public int ISBN { get; set; }
        public string BookName { get; set; }
        public string BorrowedDate { get; set; }
        public string DeliveryDate { get; set; }
    }
}
