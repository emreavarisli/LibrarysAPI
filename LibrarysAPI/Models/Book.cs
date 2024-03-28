using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibrarysAPI.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; } //Kitap ID
        public string BookName { get; set; } //Kitap İsmi
        public string Author { get; set; } //Yazar
        public int ISBN { get; set; } //ISBN numarası
        public string Genre { get; set; } //Tür
        public string PublicationDate { get; set; } //Yayın Tarihi
    }
}
