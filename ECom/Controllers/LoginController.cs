using ECom.Data;
using ECom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(Signup obj)
        {
            if (ModelState.IsValid)
            {
                _db.Signup.Add(obj);
                _db.SaveChanges();
               // return RedirectToAction("Index");
            }
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Signup obj)
        {
            IEnumerable<Signup> objList = _db.Signup;
            return View();
        }


    }
}
