using dotnettraining.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnettraining.Controllers
{
    public class ResetPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserCredential user)
        {
            TempData["username"] = user.Username;

            return View(user);
        }

        public IActionResult SuccessfulReset()
        {
            
            return View("Index");
        }
    }
}
