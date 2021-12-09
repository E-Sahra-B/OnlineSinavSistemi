using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class KonuSorulariController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KonuSoruListesi()
        {
            return View();
        }
    }
}