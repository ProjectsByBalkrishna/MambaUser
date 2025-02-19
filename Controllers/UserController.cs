using MambaUser.Data;
using MambaUser.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MambaUser.Controllers
{
    public class User(AppDbContext context) : Controller
    {

        private readonly AppDbContext _context = context;

        public IActionResult AllUser()
        {
            var allusers = _context.Users.ToList();
            return View(allusers);

        }

[HttpGet]
public IActionResult AddUser(){
    return View();
}
    [HttpPost]
        public IActionResult AddUser(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var kishan = new LoginUser
                {
                    UserName = user.UserName,
                    CreatedBy = 1,
                    CreatedDate = user.CreatedDate,
                    Email = user.Email,
                    IsActive = user.IsActive,
                    ModifiedBy = 1,
                    ModifiedDate = DateTime.Today,
                    Phone = user.Phone,
                    Password = user.Password
                };
                _context.Add(kishan);
                _context.SaveChanges();
                return RedirectToAction("AllUser");
            }
            return View();

        }

        public IActionResult Delete(int id){
            var user= _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("AllUser","User");
        }
        [HttpGet]
        public IActionResult Update(int id){
            if(ModelState.IsValid){
                return View(_context.Users.Find(id));
            }
            return RedirectToAction("AllUser");
        }

        [HttpPost]
        public IActionResult Update(updateuser user, int id){
            var cuser = _context.Users.Find(id);
           if(ModelState.IsValid){
            cuser.UserName=user.UserName;
            cuser.Password=user.Password;
            cuser.Phone=user.Phone;
            cuser.Email=user.Email;
            cuser.ModifiedDate=DateTime.Today;
            cuser.ModifiedBy=user.ModifiedBy;
            _context.Users.Update(cuser);
            _context.SaveChanges();
        return RedirectToAction("AllUser","User");
           }

            return View();
        }
        public IActionResult UserByID(){
            return View();
        }
        

    }
}