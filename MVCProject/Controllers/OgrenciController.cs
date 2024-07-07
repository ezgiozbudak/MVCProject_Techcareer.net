using MVCProject.Models;
using MVCProject.Veriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Goster()
        {
            return View(OgrenciVerileri.ogrenciler);
        }

        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kayit(Ogrenci ogrenci)
        {
            OgrenciVerileri.ogrenciler.Add(ogrenci);
            return RedirectToAction("Goster");
        }

        public ActionResult Guncelle(int id)
        {
            var ogrencimiz = OgrenciVerileri.ogrenciler.Where(x => x.Id == id).FirstOrDefault();
            return View(ogrencimiz);
        }

        [HttpPost]
        public ActionResult Guncelle(Ogrenci ogrencimiz)
        {
            Ogrenci ogrenci = OgrenciVerileri.ogrenciler.Where(x => x.Id == ogrencimiz.Id).FirstOrDefault();
            ogrenci.Ad = ogrencimiz.Ad;
            ogrenci.Soyad = ogrencimiz.Soyad;
            ogrenci.TcNo = ogrencimiz.TcNo;
            ogrenci.BolumAdi = ogrencimiz.BolumAdi;
            ogrenci.EpostaAdresi = ogrencimiz.EpostaAdresi;
            ogrenci.KayitYili = ogrencimiz.KayitYili;
            ogrenci.DogumYeri = ogrencimiz.DogumYeri;
            
            return RedirectToAction("Goster");
        }

    }
}