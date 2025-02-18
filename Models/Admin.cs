using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MambaUser.Models{
    public class Admin{
        [Key]
        public int AdminID { get; set; }
        public required string Name { get; set; }
        public required string  Password { get; set; }
    }
}