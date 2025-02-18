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
        public double Price { get; set; }
        public string? Description { get; set; }
        public  int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Today;
        public int Modifiedby { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Today;

        public Category Category { get; set; }
        public bool IsActive { get; set; }
    }

    public class Updatebooks
    {

        public required string Name { get; set; }
        public required string Author { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public  int Modifiedby { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Today;
        public bool IsActive { get; set; }
        public Category Category { get; set; }

    }
}