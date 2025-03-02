using System.ComponentModel.DataAnnotations;
using MambaUser.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MambaUser.Models
{
    public class IssueBook
    {
        [Key]
        public int IssueID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime IssueDate { get; set; }
    }
}