using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace UI.Filters
{
    public class LoginFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
          Kullanici loginUser =  context.HttpContext.Session.GetObject<Kullanici>("lgnUser");
            if (loginUser == null )
            {
                context.Result = new RedirectToActionResult("Login", "Kullanici", null);
                //context.Result = new RedirectResult("/Kullanici/Login");
            }
            else if(context.HttpContext.Request.Path =="/Kullanici/Login")
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);

            }
        }
    }
}
