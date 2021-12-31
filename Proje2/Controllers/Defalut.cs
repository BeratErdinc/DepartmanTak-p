using Microsoft.AspNetCore.Mvc;
using Proje2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Controllers
{
    public class Defalut : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Birims.ToList();
            return View(degerler);
        }
        [HttpGet] // SAYFA YUKLENIRKEN
        public IActionResult YeniBirim()
        {
            return View();
        }

        [HttpPost] // Sayfamda post işlemi gerçekleştiriken çalışır
        public IActionResult YeniBirim(Birim b)
        {
            c.Birims.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
      
        public IActionResult BirimGetir(int id)
        {
            var dep = c.Birims.Find(id);
            return View("BirimGetir", dep);
        }

        public IActionResult BirimGüncelle(Birim b)
        {
            var dep = c.Birims.Find(b.BirimId);
            
            dep.Ad = b.Ad;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult BirimDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.BirimId == id).ToList();
            var birimad = c.Birims.Where(x => x.BirimId == id).Select(y => y.Ad).FirstOrDefault();
            ViewBag.brm = birimad;
            return View(degerler);
        }
    }


}
