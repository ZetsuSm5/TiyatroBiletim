using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiyatroBİLETİM.Enity;

namespace TiyatroBİLETİM.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Oyunlars.Where(i => i.IsHome && i.Yer).ToList());
        }
        public ActionResult Oyunlar()
        {
            return View(_context.Oyunlars.Where( i =>i.Yer).ToList());
        }
        public ActionResult FilmDetayları(int id)
        {
            return View(_context.Oyunlars.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult BiletFiyatlari()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }

    }
}