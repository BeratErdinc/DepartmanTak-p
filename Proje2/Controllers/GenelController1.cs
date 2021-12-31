using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Controllers
{
    public class GenelController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
