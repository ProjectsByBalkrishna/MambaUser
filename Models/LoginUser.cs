
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MambaUser.Models{
    public class LoginUser{
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email {get;set; }
        public required long Phone  { get; set; }
        public bool  IsActive { get; set; }
        public DateTime CreatedDate { get; set; } =DateTime.Today;
        public Admina CreatedBy {get;set;}
        public DateTime ModifiedDate{get;set;}= DateTime.Today;
        public Admina ModifiedBy{get;set;}

    }
}