using System.ComponentModel.DataAnnotations;

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
        public required Admin CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public required Admin Modifiedby { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
    }

    public class Updatebooks
    {

        public required string Name { get; set; }
        public required string Author { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public required Admin Modifiedby { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
    }
}