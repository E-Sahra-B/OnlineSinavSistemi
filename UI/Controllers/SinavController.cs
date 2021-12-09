using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class SinavController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sinav()
        {
            return View();
        }

        public IActionResult SinavGirisYeri()
        {
            return View();
        }
    }
}