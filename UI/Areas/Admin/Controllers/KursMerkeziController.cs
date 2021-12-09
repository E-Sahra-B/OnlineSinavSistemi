using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace UI.Areas.Admin.Controllers
{
    public class KursMerkeziController : AdminBaseController
    {
        IUnitOfWork service;
        public KursMerkeziController(IUnitOfWork _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult Listele()
        {
            ICollection<KursMerkezii> liste = service.KursMerkezi.GetAll(x => x.SilindiMi == false).Data;
            return View(liste);
        }


        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(KursMerkezii model)
        {
            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.KursMerkezi.Add(model);
            service.SaveChanges();
            return RedirectToAction(nameof(Ekle));
        }


        [HttpPost]
        public IActionResult Sil(int id)
        {
            service.KursMerkezi.SoftDelete(id);
            service.SaveChanges();
            return RedirectToAction(nameof(Listele));
        }


        
        public IActionResult Guncelle(int kursMerkeziId)
        {
            var sonuc = service.KursMerkezi.GetAll(x => x.Id == kursMerkeziId && x.SilindiMi == false).Data;
            return View(sonuc);
        }

        [HttpPost]
        public IActionResult Guncelle(KursMerkezii model)
        {
            //ekleme işlemi ypaulacak.
            model.GuncellemeTarihi = DateTime.Now;
            service.KursMerkezi.Update(model);
            service.SaveChanges();
            return RedirectToAction(nameof(Listele));
        }

        public IActionResult IlveIlceyeGoreSirala(string il,string ilce,string ad)
        {
            var liste = service.KursMerkezi.GetAll(x => x.Il == il && x.Ilce == ilce && x.Ad==ad).Data;
            return View(liste);
        }

    }
}