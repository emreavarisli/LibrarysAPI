namespace LibrarysAPI.Models
{
    public class UpdateUserRequest
    {
        public string FullName { get; set; } 
        public string Phone { get; set; } 
        public string Address { get; set; } 
        public string EMail { get; set; } 
        public string DateRegistered { get; set; } 
        public string Status { get; set; } 
    }
}
