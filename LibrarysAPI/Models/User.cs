using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibrarysAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; } //User ID
        public string FullName { get; set; } //Ad-Soyad
        public string Phone {  get; set; } //Telefon
        public string Address { get; set; } //Adres
        public string EMail {  get; set; } //E-mail
        public string DateRegistered { get; set; } //Kayıt Tarihi
        public string Status { get; set; } //Hesap Durumu
    }
}
