using MambaUser.Data;
using MambaUser.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MambaUser.Controllers
{
    public class Book : Controller
    {
        private readonly AppDbContext _context;
        public Book(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(books boks)
        {
            if (ModelState.IsValid)
            {


                var newbook = new books()
                {
                    Name = boks.Name,
                    Price = boks.Price,
                    Author = boks.Author,
                    Description = boks.Description,
                    CreatedBy = boks.CreatedBy,
                    CreatedDate = boks.CreatedDate,
                    IsActive = boks.IsActive,                   
                    Category= boks.Category

                };

                _context.Books.Add(newbook);
                _context.SaveChanges();
                return RedirectToAction("AllUser");
            }
            else
            {
                ViewData["message"] = "invalid modelstate";
                return View();
            }
        }

        public IActionResult AllUser()
        {
            var all = _context.Books.ToList();
            return View(all);
        }

        public IActionResult Update(int id, Updatebooks book)
        {
            if (ModelState.IsValid)
            {
                var Upbook = _context.Books.Find(id);
                if (Upbook != null)
                {
                    Upbook.Name = book.Name;
                    Upbook.Price = book.Price;
                    Upbook.Author = book.Author;
                    Upbook.Description = book.Description;
                    Upbook.ModifiedDate=DateTime.Today;
                    Upbook.Modifiedby=1;
                    Upbook.IsActive = book.IsActive;
                    Upbook.Category = book.Category;
                    _context.Books.Update(Upbook);
                    _context.SaveChanges();
                }

                return RedirectToAction("AllUser", "Book");
            }
            else
            {
                ViewData["IM"] = "Invalid modelstate";
                //return View();
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var delbook = _context.Books.Find(id);
                if (delbook != null)
                {
                    _context.Books.Remove(delbook);
                    _context.SaveChanges();
                    return RedirectToAction("AllUser", "Book");
                }
            }
            return View();
        }


    }
}