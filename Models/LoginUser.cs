
using System.ComponentModel.DataAnnotations;

namespace MambaUser.Models{
    public class LoginUser{
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public EmailAddressAttribute Email {get;set; }
        public required long Phone  { get; set; }
        public bool  IsActive { get; set; }
        public DateTime CreatedDate { get; set; } =DateTime.Today;
        public Admin CreatedBy {get;set;}
        public DateTime ModifiedDate{get;set;}= DateTime.Today;
        public Admin ModifiedBy{get;set;}

    }
}