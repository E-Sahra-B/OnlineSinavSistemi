using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UI.Areas.Admin.Controllers
{
    public class SikayetController : AdminBaseController
    {
        IUnitOfWork service;
        public SikayetController(IUnitOfWork _service)
        {
            service = _service;
        }
        public IActionResult Listele()
        {
            ICollection<Sikayet> liste = service.Sikayet.GetAll(x => x.SilindiMi == false).Data;
            return View(liste);
        }

        [HttpPost]
        public IActionResult Sil(int id)
        {
            service.Sikayet.SoftDelete(id);
            service.SaveChanges();
            return RedirectToAction(nameof(Listele));
        }
    }
}