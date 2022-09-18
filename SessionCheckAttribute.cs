using dotnettraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace dotnettraining
{
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            User u = controller.TempData.Peek<User>("_user");

            if (u == null)
            {
                context.Result = new RedirectToActionResult(
                        controllerName: "User",
                        actionName: "Index",
                        routeValues: new { m = "loginRequired" }
                    );
                //controller.RedirectToAction(controllerName: "User", actionName: "Index");
            }

            base.OnActionExecuting(context);
        }
    }
}
