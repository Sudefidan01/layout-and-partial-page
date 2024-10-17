using _09122023_LayoutAndPartialPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09122023_LayoutAndPartialPage.Controllers
{
    public class HomeController : Controller
    {
        List<Kisi> kisiler=new List<Kisi>()
        {
            new Kisi(){Ad="Mehmet",Soyad="Kaynar",Unvan="Çaycı"},
            new Kisi(){Ad="Selma",Soyad="Gökçe",Unvan="Komi"},
            new Kisi(){Ad="Barış",Soyad="Kaya",Unvan="Garson"},
            new Kisi(){Ad="İpek",Soyad="Solmaz",Unvan="Müdür"},
        };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sayfa2()
        {
            return View();
        }
        public ActionResult Sayfa3() 
        {
            return View(kisiler);
        }
    }
}