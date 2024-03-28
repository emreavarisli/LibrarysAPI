namespace LibrarysAPI.Models
{
    public class BorrowedBook
    {
        public int Id { get; set; } //Ödünç alınan kitabın id
        public int UserId { get; set; } //Ödünç alan kişinin id
        public int BookId { get; set; } //Ödünç alınan kitabın id
        public int ISBN { get; set; } //ISBN numarası
        public string BookName { get; set; } //Ödünç alınan kitabın adı
        public string BorrowedDate { get; set; } //Ödünç alınma tarihi
        public string DeliveryDate { get; set; } //Teslim tarihi
    }
}
