using Microsoft.AspNetCore.Mvc;
using Proje2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Proje2.Controllers
{
    public class Personel : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x => x.birim).ToList();
            return View(degerler);
        }

        [HttpGet] // SAYFA YUKLENIRKEN
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Ad,
                                                 Value = x.BirimId.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        public IActionResult YeniPersonel(personel p)
        {
            var per = c.Birims.Where(x => x.BirimId == p.birim.BirimId).FirstOrDefault();
            p.birim = per;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelSil(int id)
        {
            var dep = c.Personels.Find(id);
            c.Personels.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult PersonelGetir(int id)
        {
            var dep = c.Personels.Find(id);
            return View("PersonelGetir", dep);
        }

        public IActionResult PersonelGüncelle(personel p)
        {
            var dep = c.Personels.Find(p.PersonelId);
            dep.Ad = p.Ad;
            dep.Soyad = p.Soyad;
            dep.Sehir = p.Sehir;
            c.SaveChanges();
            return RedirectToAction("Liste");





        }
    }
}
