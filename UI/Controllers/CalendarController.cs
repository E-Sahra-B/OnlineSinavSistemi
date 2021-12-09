using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CalendarController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}