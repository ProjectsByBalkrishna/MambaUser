
using System.ComponentModel.DataAnnotations;

namespace MambaUser.Models{
    public class LoginUser{
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword {get;set; }
    }
}