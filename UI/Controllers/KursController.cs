using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class KursController : Controller
    {
        IUnitOfWork service;
        public KursController(IUnitOfWork _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KursDuzenle()
        {
            return View();
        }
        public IActionResult Siniflarim()
        {
            return View();
        }

        public IActionResult Ogrencilerim()
        {
            return View();
        }

        public IActionResult SinavOlustur()
        {
            return View();
        }
    }
}