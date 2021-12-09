using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class OgrenimBilgileriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SinavSonuclariveNotlari()
        {
            return View();
        }

        public IActionResult Sertifikalarim()
        {
            return View();
        }
        public IActionResult SertifikaDetay()
        {
            return View();
        }
    }
}