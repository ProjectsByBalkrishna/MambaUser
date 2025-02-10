using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MambaUser.Models;
using MambaUser.Data;

namespace MambaUser.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;
    
    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context= context;
    }
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("UserLoggedIn ")== "true")
        {
           return View();
        }
        else
        { return RedirectToAction("Login");
        }
       
    }
    //[HttpGet]
    //  public IActionResult Register(){
    //  return  View();
    //  }
    //  [HttpPost]
    //   public IActionResult Register(LoginUser user)
    //   {
    //       if(ModelState.IsValid)
    //       {
    //           var newuser = new LoginUser{
    //               UserName= user.UserName,
    //               Password= user.Password
    //           };

    //           ViewData["Message"]=newuser.UserName;
    //           _context.Users.Add(newuser);
    //           _context.SaveChanges();
    //           return RedirectToAction("Index","Home");
    //       }
    //       ViewData["Message"]="The model state is not valid";
    //       return View();
    //   }

    //   [HttpGet]
    //   public IActionResult Login(){
    //       return View();
    //   }

    //   [HttpPost]
    //   public IActionResult Login(LoginUser loggeduser)
    //   {
    //       if (ModelState.IsValid && loggeduser!=null)
    //       {
    //        _context.Users.Find(loggeduser);
    //           var loguser = loggeduser.UserID;
    //          var newoser= _context.Users.Find(loguser);
    //           if (newoser != null)
    //           {
    //               if (loggeduser.Password == newoser.Password)
    //               {
    //                HttpContext.Session.SetString("UserLoggedIn ", "true");
    //                   return RedirectToAction("Error", "Home");
    //               }
    //               else
    //               {
    //                   ViewData["Notfound"] = "User not available";
    //               }
    //           }
    //           else
    //           {
    //               ViewData["NotFound"] = "User not found, try registering";
    //           }
    //       }
    //       return View();
    //   }
    string username = "Admin";
    string Password = "Admin";


    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginUser user)
    {
        try
        {
            if (user.Password == Password && user.UserName == username)
            {
                HttpContext.Session.SetString("UserLoggedIn ", "true");
                ViewData["sucess"] = $"Thanks for Logging in {user.UserName}";

                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewData["NotSucess"] = "Invalid username or password, try again...";
                return View();
            }
        }
        catch (Exception ex)
        {
            ViewData["Sorry"] = $"Exception : {ex.Message}";
        }

        return View();

    }
    public IActionResult Logout()
    {
        HttpContext.Session.Clear(); 
        return RedirectToAction("Login");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
