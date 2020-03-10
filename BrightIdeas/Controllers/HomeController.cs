using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        public HomeController(MyContext context)
        {
            
            dbContext = context;
        }
        
        [HttpGet("")]
     
        public IActionResult Index()
        {
            return View();
        }
    
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                int? Session = HttpContext.Session.GetInt32("UserId");
                return RedirectToAction("BrightIdeas");   
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult login()
        {
            return View();
        }

          [HttpPost("process")]
        public IActionResult process(LogUser loginUser)
        {
            if(ModelState.IsValid)
            {
                User userInDB = dbContext.Users.FirstOrDefault(u => u.Email == loginUser.LEmail);
                if(userInDB == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid Email/Password");
                    return View("Login");
                }

                var hasher = new PasswordHasher<LogUser>();
                var result = hasher.VerifyHashedPassword(loginUser, userInDB.Password, loginUser.LPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LEMail", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", userInDB.UserId);
                return Redirect("BrightIdeas");

            }
            return View("Login");
        }
        
        [HttpGet("BrightIdeas")]

        public IActionResult BrightIdeas()
        {
            
            if (HttpContext.Session.GetInt32("UserId") == null )
            {
                return RedirectToAction("Index", "Login");
            }
            ViewBag.CurrentUser = dbContext.Users.Where(u => u.UserId == (int)HttpContext.Session.GetInt32("UserId")).Single();
            ViewBag.AllIdeas = dbContext.Ideas.Include(u => u.Blogger).Include(l => l.LikedBy).OrderByDescending(l => l.LikedBy.Count).ToList();
            return View();
            
        }
        [HttpPost("newIdea")]
        public IActionResult newIdea(Idea newIdea)
        {
            if (HttpContext.Session.GetInt32("UserId") == null )
            {
                return RedirectToAction("Index", "Login");
            }
                if (ModelState.IsValid)
                {
                    int? Session = HttpContext.Session.GetInt32("UserId");
                    newIdea.UserId = (int)Session;
                    dbContext.Ideas.Add(newIdea);
                    dbContext.SaveChanges();
                    return RedirectToAction("BrightIdeas");
                }
            ViewBag.CurrentUser = dbContext.Users.Where(u => u.UserId == (int)HttpContext.Session.GetInt32("UserId")).Single();
            ViewBag.AllIdeas = dbContext.Ideas.Include(u => u.Blogger).Include(l => l.LikedBy).OrderByDescending(l => l.LikedBy.Count).ToList();
            return View("BrightIdeas");
        }
        [HttpGet("Like/{IdeasId}")]

        public IActionResult Post(int IdeasId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null )
            {
                return RedirectToAction("Index", "Login");
            }
            Like NewLike = new Like()
            {
                IdeaId = IdeasId,
                UserId = (int)HttpContext.Session.GetInt32("UserId")
            };
            dbContext.Likes.Add(NewLike);
            dbContext.SaveChanges();
            return RedirectToAction("BrightIdeas");
        }
        
        [HttpGet("Users/{UserId}")]

        public IActionResult UserInform(int UserId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null )
            {
                return RedirectToAction("Index", "Login");
            } 
            ViewBag.SelectedUser = dbContext.Users.Where(u => u.UserId == UserId).Include(i => i.UserIdeas).Include(l => l.UserLikes).Single(); 
            return View();
        }

        [HttpGet("BrightIdeas/{IdeasId}")]
        public IActionResult IdeaInform(int IdeasId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null )
            {
                return RedirectToAction("Index", "Login");
            } 
            ViewBag.SelectedIdea = dbContext.Ideas.Where(i => i.IdeasId == IdeasId).Include(u => u.Blogger).Include(l => l.LikedBy).ThenInclude(u => u.User).Single(); 
            ViewBag.LikedBy = dbContext.Likes.Where(i => i.IdeaId == IdeasId).ToList();
            return View();
        }
        [HttpGet("Delete/{IdeasId}")]

        public IActionResult DeleteIdea(int IdeasId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null )
            {
                return RedirectToAction("Index", "Login");
            } 
            int? Session = HttpContext.Session.GetInt32("UserId");
            var ToDelete = dbContext.Ideas.FirstOrDefault(u => u.IdeasId == IdeasId);
            dbContext.Ideas.Remove(ToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("BrightIdeas");
        }


                
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
         HttpContext.Session.Clear();
         return View("Index");   
        }
    }
}
