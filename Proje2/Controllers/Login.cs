using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Proje2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Proje2.Controllers
{
    public class Login : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult>GirisYap(Admin p)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanıcı == p.Kullanıcı && x.Şifre == p.Şifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Name,p.Kullanıcı)
                };
                var useridentity = new ClaimsIdentity(claims ,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personel");
            }
            return View();
        }
    }
}
