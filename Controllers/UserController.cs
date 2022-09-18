using dotnettraining.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnettraining.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            User u = TempData.Peek<User>("_user");

            if (u != null)
            {
                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }

            return View();
        }


        [HttpPost]
        public IActionResult Login(UserCredential user)
        {
            if (isValidUser(user))
            {
                TempData.Put<User>("_user",GetUserSession(user)); 
                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }

            ViewBag.Message = "Invalid login credentials";
            return View(user);
        }

        public IActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction(controllerName:"User",actionName:"Index");
        }

        private User? GetUserSession(UserCredential user)
        {
            //
            return new User
            {
                UserId = user.Username,
                UserName = user.Username,
                IsAdmin = true
            };

        }

        private bool isValidUser(UserCredential user)
        {
            // call ad service to authenticate
            return true;
        }
    }
}
