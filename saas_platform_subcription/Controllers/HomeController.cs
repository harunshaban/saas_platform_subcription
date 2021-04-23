using saas_platform_subcription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace saas_platform_subcription.Controllers
{
    public class HomeController : Controller
    {

        AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetRegions()
        {
            return Json(db.Regions.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCountries()
        {
            return Json(db.Countries.ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}