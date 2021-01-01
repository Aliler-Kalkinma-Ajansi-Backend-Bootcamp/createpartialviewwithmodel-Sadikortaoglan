using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApps.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Detaylar(Models.Urun detay)
        {
            var bilgi = new Models.Urun();
            bilgi.adi = "Bilgisayar";
            bilgi.aciklamasi = "5 inc";
            bilgi.fiyat = 7500;
            bilgi.turu = "Asus";
            bilgi.durum = true;

            return View(bilgi);
        }
    }
}
