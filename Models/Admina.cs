using System.ComponentModel.DataAnnotations;

namespace MambaUser.Models{
    public class Admina{
        [Key]
        public int AdminID { get; set; }
        public required string Name { get; set; }
        public required string  Password { get; set; }
    }
}