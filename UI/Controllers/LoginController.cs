using Microsoft.AspNetCore.Mvc;
using UI.Filters;
using System;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        [MyExceptionFilter]
        public IActionResult Index()
        {
            throw new Exception();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Lock()
        {
            return View();
        }
    }
}