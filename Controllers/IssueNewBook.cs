using MambaUser.Data;
using MambaUser.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MambaUser.Controllers
{
    public class IssueNewBook : Controller
    {
        private readonly AppDbContext _context;

        public IssueNewBook(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            var users = _context.Users.Select(u => new SelectListItem
            {
                Value = u.UserID.ToString(),
                Text = u.UserName
            }).ToList();

            var books = _context.Books.Select(b => new SelectListItem
            {
                Value = b.BookId.ToString(),
                Text = b.Name
            }).ToList();

            // Store in ViewBag
            ViewBag.Users = users;
            ViewBag.Books = books;

            return View();
        }
    
  
        [HttpPost]
        public IActionResult Index(IssueBook issuedBook)
        {
            if (ModelState.IsValid)
            {
                var book = _context.Books.Find(issuedBook.BookID);
                book.IsActive = false;
                var user = _context.Users.Find(issuedBook.UserID);
                user.IsActive = false;
                _context.IssueBooks.Add(issuedBook);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Refill dropdowns if model validation fails
            ViewBag.Users = _context.Users.Where(x => x.IsActive==true).Select(u => new SelectListItem
            {
                Value = u.UserID.ToString(),
                Text = u.UserName
            }).ToList();

            ViewBag.Books = _context.Books.Where(x => x.IsActive==true).Select(b => new SelectListItem
            {
                Value = b.BookId.ToString(),
                Text = b.Name
            }).ToList();

            return View(issuedBook);
        }
    
        public IActionResult AllIssuedBook()
        {
           
            return View(_context.IssueBooks.ToList());
        }
    }

       
}
