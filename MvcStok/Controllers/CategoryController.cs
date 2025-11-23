using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MvcDBEntities db = new MvcDBEntities();

        public ActionResult Index()
        {
            var degerler = db.TblCategory.ToList();
            return View(degerler);
        }
    }
}