using System.ComponentModel.DataAnnotations;

namespace MambaUser.Models{
    public class books{
        [Key]
        public int BookId { get; set; }
        public required string Name { get; set; }
        public required string Author{ get; set; }
        public decimal Price{get;set;}
        public string? Description { get; set; }
    }

    public class Updatebooks
    {
       
        public required string Name { get; set; }
        public required string Author { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}