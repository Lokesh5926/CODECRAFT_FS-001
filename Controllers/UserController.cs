using CODECRAFT_FS_01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CODECRAFT_FS_01.Controllers
{
    public class UserController : Controller
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        // Show Registration Form
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Save Registration Form
        [HttpPost]
        public IActionResult Create(UserModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(obj);
                _context.SaveChanges();
                ViewBag.Message = "User registered successfully!";
                return RedirectToAction("Login"); // after registration go to login
            }
            return View(obj);
        }

        // Show Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Handle Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users
                        .FirstOrDefault(u => u.username == username && u.password == password);

            if (user != null)
            {
                ViewBag.Message = "Login successful!";
                return RedirectToAction("Welcome"); // go to dashboard page
            }
            else
            {
                ViewBag.Message = "Invalid username or password.";
                return View("Login");
            }
        }

        // Simple welcome page
        public IActionResult Welcome()
        {
            return View();
        }
    }
}