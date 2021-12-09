using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Derslerim()
        {
            return View();
        }
        public IActionResult DersListesi()
        {
            return View();
        }

        public IActionResult DersSayfasi()
        {
            return View();
        }
    }
}