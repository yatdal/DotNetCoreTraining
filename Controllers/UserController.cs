using dotnettraining.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnettraining.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserCredential user)
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(UserCredential user)
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult ForgotPassword(UserCredential user)
        {
            return View("Index");
        }

    }
}
