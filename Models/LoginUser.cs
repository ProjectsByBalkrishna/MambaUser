
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MambaUser.Models
{
    public class LoginUser
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public required long Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Today;
        public int ModifiedBy { get; set; }
    }

      public class updateuser
    {
      
        public string UserName { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        public required long Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Today;
        public int ModifiedBy { get; set; }
    }
}