using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class UrunController : Controller
    {
        // GET: Ürün

        MvcDBEntities db =new MvcDBEntities();
        public ActionResult Index()
        {
            var degerler = db.TblUrun.ToList();
            return View(degerler);
        }

        
    }
}