using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nursery.Models;

namespace Nursery.Controllers
{
    public class NurceryController : Controller
    {
        private readonly ApplicationDbContext _dbcontext = null;

        public NurceryController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        // GET: Nurcery
        public ActionResult Index()
        {
            var NurceryItem=_dbcontext.nurseries.ToList();
            return View(NurceryItem);
        }

        public ActionResult Detais(int id)
        {
            var items = _dbcontext.nurseries.FirstOrDefault(x => x.Id == id);

            if(items != null)
            {
                return View(items); 
            }
            return HttpNotFound();
        }
        //GET
        [HttpGet]
        public ActionResult create()
        {
            
            var categories = _dbcontext.categories.ToList();
            ViewBag.categories = categories;
            return View();
        }

        //[HttpPost]
        //public ActionResult create()
        //{
        //    return View();
        //}

    }
}