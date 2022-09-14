using dotnettraining.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnettraining.Controllers
{
    public class UserController : Controller
    {
        private IConfiguration _config;

        public UserController(IConfiguration config)
        {
            _config = config;
        }

        public class Message
        {
            public string MessageType { get; set; }
            public string MessageData { get; set; }
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.APIKey = _config["APIKeys:GoogleMaps"];
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserCredential user)
        {
            user.Username = "abcdef";
            return View(user); // this does not work. (why?)
        }

        [HttpPost]
        public IActionResult New(UserCredential user)
        {
            // user create
            Message m = new Message()
            {
                MessageData = "User created",
                MessageType = "S"
            };
            //ViewData["Message"] = m ;
            ViewBag.Message = m;
            user.Username = "abcdefgh";
            return View("Index",user); // this works (why?)   
        }

        [HttpPost]
        public IActionResult ForgotPassword(UserCredential user)
        {
            //// reset email
            //Message m = new Message()
            //{
            //    MessageData = "Email sent to registered email",
            //    MessageType = "S"
            //};
            ////ViewData["Message"] = m;
            ////ViewData["Message"] = "Email sent to registered email";
            //ViewBag.Message = m;
            //return View("Index",user);

            TempData["username"] = user.Username;
            //keep?
            return RedirectToAction(controllerName: "ResetPassword", actionName: "Index");
        }

    }
}
