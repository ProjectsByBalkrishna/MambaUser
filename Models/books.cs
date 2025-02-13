using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MambaUser.Models
{
    public class books
    {
        [Key]
        public int BookId { get; set; }
        public required string Name { get; set; }
        public required string Author { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public  int CreatorAdminID;
        [ForeignKey("CreatorAdminID")]
        public  Admina CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public  int ModifierAdminID;
        [ForeignKey("ModifierAdminID")]
        public  Admina Modifiedby { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public bool IsActive { get; set; }
    }

    public class Updatebooks
    {

        public required string Name { get; set; }
        public required string Author { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int ModifierAdminID { get; set; }
        [ForeignKey("ModifierAdminID")]
        public  Admina Modifiedby { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

    }
}