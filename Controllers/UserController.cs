using Microsoft.AspNetCore.Mvc;

namespace dotnettraining.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string p1, string p2)
        {
            return View();
        }
    }
}
